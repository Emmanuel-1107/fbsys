#ifndef DATABASE_MANAGER_H
#define DATABASE_MANAGER_H

#include "StudentFeedback.h"
#include "AnalyticsEngine.h"
#include <string>
#include <vector>

class DatabaseManager {
private:
    std::string host;
    std::string user;
    std::string password;
    std::string database;
    int         port;

public:
    DatabaseManager(const std::string& host,
                    const std::string& user,
                    const std::string& password,
                    const std::string& database,
                    int port = 3306);
    ~DatabaseManager();

    bool connect();
    void disconnect();

    bool insertFeedback(StudentFeedback& feedback);
    std::vector<FeedbackRecord> getAllFeedback() const;
    std::vector<FeedbackRecord> getFilteredFeedback(
        const std::string& semester,
        const std::string& subjectCode,
        const std::string& instructor) const;

    std::vector<std::pair<std::string,std::string>> getAllSubjects() const;
    std::vector<std::string> getInstructorsBySubject(const std::string& subjectCode) const;

    bool verifyAdmin(const std::string& username,
                     const std::string& password) const;

    bool verifyStudent(const std::string& studentID,
                       const std::string& password) const;
    bool hasAlreadySubmitted(const std::string& studentID,
                             const std::string& subjectCode) const;
    bool recordSubmission(const std::string& studentID,
                          const std::string& subjectCode);
    bool changeStudentPassword(const std::string& studentID,
                               const std::string& newPassword);
};

#endif
