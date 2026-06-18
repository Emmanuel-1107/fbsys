#include "DatabaseManager.h"
#include "StudentFeedback.h"
#include "AnalyticsEngine.h"
#include <mysql.h>
#include <iostream>
#include <sstream>
#include <vector>
#include <string>

// Global MySQL connection pointer
static MYSQL* conn = nullptr;

DatabaseManager::DatabaseManager(const std::string& host,
                                 const std::string& user,
                                 const std::string& password,
                                 const std::string& database,
                                 int port)
    : host(host), user(user), password(password),
      database(database), port(port)
{
    connect();
}

DatabaseManager::~DatabaseManager() {
    disconnect();
}

bool DatabaseManager::connect() {
    conn = mysql_init(nullptr);
    if (!conn) {
        std::cerr << "[DB] mysql_init failed\n";
        return false;
    }
    if (!mysql_real_connect(conn,
            host.c_str(), user.c_str(), password.c_str(),
            database.c_str(), port, nullptr, 0)) {
        std::cerr << "[DB] Connection failed: " << mysql_error(conn) << "\n";
        return false;
    }
    std::cout << "[DB] Connected to " << database << "\n";
    return true;
}

void DatabaseManager::disconnect() {
    if (conn) {
        mysql_close(conn);
        conn = nullptr;
    }
}

bool DatabaseManager::insertFeedback(StudentFeedback& feedback) {
    if (!conn) return false;

    std::ostringstream query;
    query << "INSERT INTO feedback "
          << "(username, subject_code, instructor, semester, "
          << "subject_rating, instructor_rating, comments, ip_hash) VALUES (";

    if (feedback.getUsername().empty())
        query << "NULL,";
    else
        query << "'" << feedback.getUsername() << "',";

    query << "'" << feedback.getSubjectCode()       << "',"
          << "'" << feedback.getInstructor()         << "',"
          << "'" << feedback.getSemester()           << "',"
          <<        feedback.getRating()             << ","
          <<        feedback.getInstructorRating()   << ",";

    if (feedback.getComments().empty())
        query << "NULL,";
    else
        query << "'" << feedback.getComments() << "',";

    query << "'" << feedback.getIpHash() << "')";

    if (mysql_query(conn, query.str().c_str())) {
        std::cerr << "[DB] Insert failed: " << mysql_error(conn) << "\n";
        return false;
    }
    feedback.setFeedbackID(static_cast<int>(mysql_insert_id(conn)));
    return true;
}

std::vector<FeedbackRecord> DatabaseManager::getAllFeedback() const {
    std::vector<FeedbackRecord> results;
    if (!conn) return results;

    const char* query =
        "SELECT id, COALESCE(username,''), subject_code, instructor, "
        "semester, subject_rating, instructor_rating, "
        "COALESCE(comments,''), created_at FROM feedback ORDER BY id DESC";

    if (mysql_query(conn, query)) {
        std::cerr << "[DB] Query failed: " << mysql_error(conn) << "\n";
        return results;
    }

    MYSQL_RES* res = mysql_store_result(conn);
    MYSQL_ROW  row;
    while ((row = mysql_fetch_row(res))) {
        FeedbackRecord r;
        r.feedbackID       = std::stoi(row[0]);
        r.username         = row[1];
        r.subjectCode      = row[2];
        r.instructor       = row[3];
        r.semester         = row[4];
        r.subjectRating    = std::stoi(row[5]);
        r.instructorRating = std::stoi(row[6]);
        r.comments         = row[7];
        r.timestamp        = row[8];
        results.push_back(r);
    }
    mysql_free_result(res);
    return results;
}

std::vector<FeedbackRecord> DatabaseManager::getFilteredFeedback(
    const std::string& semester,
    const std::string& subjectCode,
    const std::string& instructor) const
{
    std::vector<FeedbackRecord> results;
    if (!conn) return results;

    std::ostringstream query;
    query << "SELECT id, COALESCE(username,''), subject_code, instructor, "
          << "semester, subject_rating, instructor_rating, "
          << "COALESCE(comments,''), created_at FROM feedback WHERE 1=1";

    if (!semester.empty())
        query << " AND semester='"     << semester    << "'";
    if (!subjectCode.empty())
        query << " AND subject_code='" << subjectCode << "'";
    if (!instructor.empty())
        query << " AND instructor='"   << instructor  << "'";

    query << " ORDER BY id DESC";

    if (mysql_query(conn, query.str().c_str())) {
        std::cerr << "[DB] Filter failed: " << mysql_error(conn) << "\n";
        return results;
    }

    MYSQL_RES* res = mysql_store_result(conn);
    MYSQL_ROW  row;
    while ((row = mysql_fetch_row(res))) {
        FeedbackRecord r;
        r.feedbackID       = std::stoi(row[0]);
        r.username         = row[1];
        r.subjectCode      = row[2];
        r.instructor       = row[3];
        r.semester         = row[4];
        r.subjectRating    = std::stoi(row[5]);
        r.instructorRating = std::stoi(row[6]);
        r.comments         = row[7];
        r.timestamp        = row[8];
        results.push_back(r);
    }
    mysql_free_result(res);
    return results;
}

std::vector<std::pair<std::string,std::string>>
DatabaseManager::getAllSubjects() const
{
    std::vector<std::pair<std::string,std::string>> results;
    if (!conn) return results;

    const char* query =
        "SELECT subject_code, subject_name FROM subjects "
        "WHERE is_active=1 ORDER BY subject_code";

    if (mysql_query(conn, query)) return results;

    MYSQL_RES* res = mysql_store_result(conn);
    MYSQL_ROW  row;
    while ((row = mysql_fetch_row(res)))
        results.push_back({row[0], row[1]});
    mysql_free_result(res);
    return results;
}

std::vector<std::string> DatabaseManager::getInstructorsBySubject(
    const std::string& subjectCode) const
{
    std::vector<std::string> results;
    if (!conn) return results;

    std::ostringstream query;
    query << "SELECT i.full_name FROM instructors i "
          << "JOIN subject_instructor si ON i.id = si.instructor_id "
          << "JOIN subjects s ON s.id = si.subject_id "
          << "WHERE s.subject_code='" << subjectCode << "' AND i.is_active=1";

    if (mysql_query(conn, query.str().c_str())) return results;

    MYSQL_RES* res = mysql_store_result(conn);
    MYSQL_ROW  row;
    while ((row = mysql_fetch_row(res)))
        results.push_back(row[0]);
    mysql_free_result(res);
    return results;
}

bool DatabaseManager::verifyAdmin(const std::string& username,
                                  const std::string& password) const
{
    if (!conn) return false;

    std::ostringstream query;
    query << "SELECT COUNT(*) FROM admin_users WHERE username='"
          << username << "' AND password_hash='" << password
          << "' AND is_active=1 LIMIT 1";

    if (mysql_query(conn, query.str().c_str())) return false;

    MYSQL_RES* res   = mysql_store_result(conn);
    MYSQL_ROW  row   = mysql_fetch_row(res);
    int        count = row ? std::stoi(row[0]) : 0;
    mysql_free_result(res);
    return count > 0;
}

// ============================================================
//  verifyStudent
//  username = student_id, password = last_name (or changed)
// ============================================================
bool DatabaseManager::verifyStudent(const std::string& studentID,
                                    const std::string& password) const
{
    if (!conn) return false;
    std::ostringstream query;
    query << "SELECT COUNT(*) FROM students WHERE student_id='"
          << studentID << "' AND password_hash='" << password
          << "' AND is_active=1 LIMIT 1";
    if (mysql_query(conn, query.str().c_str())) return false;
    MYSQL_RES* res   = mysql_store_result(conn);
    MYSQL_ROW  row   = mysql_fetch_row(res);
    int        count = row ? std::stoi(row[0]) : 0;
    mysql_free_result(res);
    return count > 0;
}

// ============================================================
//  hasAlreadySubmitted
//  Returns true if student already submitted for this subject
// ============================================================
bool DatabaseManager::hasAlreadySubmitted(const std::string& studentID,
                                          const std::string& subjectCode) const
{
    if (!conn) return false;
    std::ostringstream query;
    query << "SELECT COUNT(*) FROM feedback_submissions WHERE student_id='"
          << studentID << "' AND subject_code='" << subjectCode << "' LIMIT 1";
    if (mysql_query(conn, query.str().c_str())) return false;
    MYSQL_RES* res   = mysql_store_result(conn);
    MYSQL_ROW  row   = mysql_fetch_row(res);
    int        count = row ? std::stoi(row[0]) : 0;
    mysql_free_result(res);
    return count > 0;
}

bool DatabaseManager::recordSubmission(const std::string& studentID,
                                       const std::string& subjectCode)
{
    if (!conn) return false;
    std::ostringstream query;
    query << "INSERT INTO feedback_submissions (student_id, subject_code) VALUES ('"
          << studentID << "','" << subjectCode << "')";
    return mysql_query(conn, query.str().c_str()) == 0;
}


bool DatabaseManager::changeStudentPassword(const std::string& studentID,
                                            const std::string& newPassword)
{
    if (!conn) return false;
    std::ostringstream query;
    query << "UPDATE students SET password_hash='" << newPassword
          << "' WHERE student_id='" << studentID << "'";
    return mysql_query(conn, query.str().c_str()) == 0;
}
