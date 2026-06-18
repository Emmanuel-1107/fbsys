#include <cstring>
#include <cstdio>
#include <string>
#include <sstream>
#include "StudentFeedback.h"
#include "AdminUser.h"
#include "AnalyticsEngine.h"
#include "DatabaseManager.h"

DatabaseManager db("localhost", "root", "admin123", "student_feedback_db");

static char returnBuffer[65536];

extern "C" __declspec(dllexport)
bool SubmitFeedback(const char* username,
                    const char* subjectCode,
                    const char* instructor,
                    const char* semester,
                    int subjectRating,
                    int instructorRating,
                    const char* comments,
                    const char* ipHash)
{
    StudentFeedback fb(
        username     ? username     : "",
        subjectRating,
        comments     ? comments     : "",
        ipHash       ? ipHash       : "",
        subjectCode  ? subjectCode  : "",
        instructor   ? instructor   : "",
        semester     ? semester     : "",
        instructorRating
    );

    if (!fb.validate()) return false;
    return db.insertFeedback(fb);
}

extern "C" __declspec(dllexport)
const char* GetSubjects()
{
    std::vector<std::pair<std::string, std::string>> subjects = db.getAllSubjects();
    std::ostringstream oss;
    for (size_t i = 0; i < subjects.size(); ++i) {
        oss << subjects[i].first << "|" << subjects[i].second;
        if (i < subjects.size() - 1) oss << ",";
    }
    strncpy(returnBuffer, oss.str().c_str(), sizeof(returnBuffer) - 1);
    return returnBuffer;
}

extern "C" __declspec(dllexport)
const char* GetInstructorsBySubject(const char* subjectCode)
{
    std::vector<std::string> instructors = db.getInstructorsBySubject(subjectCode ? subjectCode : "");
    std::ostringstream oss;
    for (size_t i = 0; i < instructors.size(); ++i) {
        oss << instructors[i];
        if (i < instructors.size() - 1) oss << ",";
    }
    strncpy(returnBuffer, oss.str().c_str(), sizeof(returnBuffer) - 1);
    return returnBuffer;
}

extern "C" __declspec(dllexport)
bool AdminLogin(const char* username, const char* password)
{
    return db.verifyAdmin(username ? username : "", password ? password : "");
}

extern "C" __declspec(dllexport)
const char* GetAllFeedback()
{
    std::vector<FeedbackRecord> records = db.getAllFeedback();
    std::ostringstream oss;
    for (size_t i = 0; i < records.size(); ++i) {
        oss << records[i].feedbackID       << "|~|"
            << records[i].username         << "|~|"
            << records[i].subjectCode      << "|~|"
            << records[i].instructor       << "|~|"
            << records[i].semester         << "|~|"
            << records[i].subjectRating    << "|~|"
            << records[i].instructorRating << "|~|"
            << records[i].comments         << "|~|"
            << records[i].timestamp;
        if (i < records.size() - 1) oss << "||";
    }
    strncpy(returnBuffer, oss.str().c_str(), sizeof(returnBuffer) - 1);
    return returnBuffer;
}

extern "C" __declspec(dllexport)
const char* GetFilteredFeedback(const char* semester,
                                 const char* subjectCode,
                                 const char* instructor)
{
    std::vector<FeedbackRecord> records = db.getFilteredFeedback(
        semester    ? semester    : "",
        subjectCode ? subjectCode : "",
        instructor  ? instructor  : ""
    );
    std::ostringstream oss;
    for (size_t i = 0; i < records.size(); ++i) {
        oss << records[i].feedbackID       << "|~|"
            << records[i].username         << "|~|"
            << records[i].subjectCode      << "|~|"
            << records[i].instructor       << "|~|"
            << records[i].semester         << "|~|"
            << records[i].subjectRating    << "|~|"
            << records[i].instructorRating << "|~|"
            << records[i].comments         << "|~|"
            << records[i].timestamp;
        if (i < records.size() - 1) oss << "||";
    }
    strncpy(returnBuffer, oss.str().c_str(), sizeof(returnBuffer) - 1);
    return returnBuffer;
}

extern "C" __declspec(dllexport)
double GetAverageSubjectRating(const char* subjectCode)
{
    AnalyticsEngine engine;
    engine.loadRecords(db.getAllFeedback());
    return engine.computeSubjectAverage(subjectCode ? subjectCode : "");
}

extern "C" __declspec(dllexport)
double GetAverageInstructorRating(const char* instructor)
{
    AnalyticsEngine engine;
    engine.loadRecords(db.getAllFeedback());
    return engine.computeInstructorAverage(instructor ? instructor : "");
}

extern "C" __declspec(dllexport)
int GetTotalResponses()
{
    AnalyticsEngine engine;
    engine.loadRecords(db.getAllFeedback());
    return engine.getTotalCount();
}

extern "C" __declspec(dllexport)
bool ExportCSV(const char* filepath)
{
    AnalyticsEngine engine;
    engine.loadRecords(db.getAllFeedback());
    return engine.exportToCSV(filepath ? filepath : "feedback_export.csv");
}

extern "C" __declspec(dllexport)
bool StudentLogin(const char* studentID, const char* password)
{
    return db.verifyStudent(studentID ? studentID : "",
                            password  ? password  : "");
}

extern "C" __declspec(dllexport)
bool HasAlreadySubmitted(const char* studentID, const char* subjectCode)
{
    return db.hasAlreadySubmitted(studentID   ? studentID   : "",
                                  subjectCode ? subjectCode : "");
}

extern "C" __declspec(dllexport)
bool RecordSubmission(const char* studentID, const char* subjectCode)
{
    return db.recordSubmission(studentID   ? studentID   : "",
                               subjectCode ? subjectCode : "");
}

extern "C" __declspec(dllexport)
bool ChangeStudentPassword(const char* studentID, const char* newPassword)
{
    return db.changeStudentPassword(studentID   ? studentID   : "",
                                    newPassword ? newPassword : "");
}
