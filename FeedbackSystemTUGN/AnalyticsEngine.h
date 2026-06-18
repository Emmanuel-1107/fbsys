#ifndef ANALYTICS_ENGINE_H
#define ANALYTICS_ENGINE_H

#include <string>
#include <vector>
#include <map>


struct FeedbackRecord {
    int         feedbackID;
    std::string username;
    std::string subjectCode;
    std::string instructor;
    std::string semester;
    int         subjectRating;
    int         instructorRating;
    std::string comments;
    std::string timestamp;
};

struct SubjectStats {
    std::string subjectCode;
    double      averageRating;
    int         totalResponses;
    int         ratingDistribution[5];
};

class AnalyticsEngine {
public:
    void loadRecords(const std::vector<FeedbackRecord>& records);

    double computeAverage(const std::string& subjectCode = "")      const;
    double computeSubjectAverage(const std::string& subjectCode)     const;
    double computeInstructorAverage(const std::string& instructor)   const;
    SubjectStats getSubjectStats(const std::string& subjectCode)     const;
    std::map<std::string, double> getRankings()                      const;
    std::vector<FeedbackRecord> filterBySemester(const std::string& semester)     const;
    std::vector<FeedbackRecord> filterByInstructor(const std::string& instructor) const;

    bool exportToCSV(const std::string& filepath) const;
    int  getTotalCount() const;

private:
    std::vector<FeedbackRecord> records;
};

#endif
