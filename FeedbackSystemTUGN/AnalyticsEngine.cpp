#include "AnalyticsEngine.h"
#include <fstream>
#include <numeric>
#include <algorithm>
#include <iostream>

void AnalyticsEngine::loadRecords(const std::vector<FeedbackRecord>& r) {
    records = r;
}

int AnalyticsEngine::getTotalCount() const {
    return static_cast<int>(records.size());
}

double AnalyticsEngine::computeAverage(const std::string& subjectCode) const {
    std::vector<int> ratings;
    for (const auto& r : records) {
        if (subjectCode.empty() || r.subjectCode == subjectCode)
            ratings.push_back(r.subjectRating);
    }
    if (ratings.empty()) return 0.0;
    return (double)std::accumulate(ratings.begin(), ratings.end(), 0) / ratings.size();
}

double AnalyticsEngine::computeSubjectAverage(const std::string& subjectCode) const {
    std::vector<int> ratings;
    for (const auto& r : records) {
        if (subjectCode.empty() || r.subjectCode == subjectCode)
            ratings.push_back(r.subjectRating);
    }
    if (ratings.empty()) return 0.0;
    return (double)std::accumulate(ratings.begin(), ratings.end(), 0) / ratings.size();
}

double AnalyticsEngine::computeInstructorAverage(const std::string& instructor) const {
    std::vector<int> ratings;
    for (const auto& r : records) {
        if (instructor.empty() || r.instructor == instructor)
            ratings.push_back(r.instructorRating);
    }
    if (ratings.empty()) return 0.0;
    return (double)std::accumulate(ratings.begin(), ratings.end(), 0) / ratings.size();
}

SubjectStats AnalyticsEngine::getSubjectStats(const std::string& subjectCode) const {
    SubjectStats stats;
    stats.subjectCode    = subjectCode;
    stats.averageRating  = 0.0;
    stats.totalResponses = 0;
    for (int i = 0; i < 5; ++i) stats.ratingDistribution[i] = 0;

    double sum = 0;
    for (const auto& r : records) {
        if (r.subjectCode == subjectCode) {
            sum += r.subjectRating;
            stats.totalResponses++;
            if (r.subjectRating >= 1 && r.subjectRating <= 5)
                stats.ratingDistribution[r.subjectRating - 1]++;
        }
    }
    if (stats.totalResponses > 0)
        stats.averageRating = sum / stats.totalResponses;
    return stats;
}

std::map<std::string, double> AnalyticsEngine::getRankings() const {
    std::map<std::string, std::vector<int>> grouped;
    for (const auto& r : records)
        grouped[r.subjectCode].push_back(r.subjectRating);

    std::map<std::string, double> rankings;
    for (const auto& pair : grouped) {
        double sum = std::accumulate(pair.second.begin(), pair.second.end(), 0);
        rankings[pair.first] = sum / pair.second.size();
    }
    return rankings;
}

std::vector<FeedbackRecord> AnalyticsEngine::filterBySemester(
    const std::string& semester) const
{
    std::vector<FeedbackRecord> result;
    std::copy_if(records.begin(), records.end(), std::back_inserter(result),
        [&](const FeedbackRecord& r){ return r.semester == semester; });
    return result;
}

std::vector<FeedbackRecord> AnalyticsEngine::filterByInstructor(
    const std::string& instructor) const
{
    std::vector<FeedbackRecord> result;
    std::copy_if(records.begin(), records.end(), std::back_inserter(result),
        [&](const FeedbackRecord& r){ return r.instructor == instructor; });
    return result;
}

bool AnalyticsEngine::exportToCSV(const std::string& filepath) const {
    std::ofstream file(filepath);
    if (!file.is_open()) {
        std::cerr << "[Export] Cannot open: " << filepath << "\n";
        return false;
    }
    file << "ID,Username,SubjectCode,Instructor,Semester,"
         << "SubjectRating,InstructorRating,Comments,Date\n";
    for (const auto& r : records) {
        file << r.feedbackID       << ","
             << r.username         << ","
             << r.subjectCode      << ","
             << r.instructor       << ","
             << r.semester         << ","
             << r.subjectRating    << ","
             << r.instructorRating << ","
             << r.comments         << ","
             << r.timestamp        << "\n";
    }
    file.close();
    return true;
}
