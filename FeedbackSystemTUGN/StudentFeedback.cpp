#include "StudentFeedback.h"
#include <iostream>
#include <regex>

StudentFeedback::StudentFeedback(const std::string& username,
                                 int subjectRating,
                                 const std::string& comments,
                                 const std::string& ipHash,
                                 const std::string& subjectCode,
                                 const std::string& instructor,
                                 const std::string& semester,
                                 int instructorRating)
    : Feedback(username, subjectRating, comments, ipHash),
      subjectCode(sanitise(subjectCode)),
      instructor(sanitise(instructor)),
      semester(sanitise(semester)),
      instructorRating(instructorRating)
{}

bool StudentFeedback::validate() {
    if (rating < 1 || rating > 5) {
        std::cerr << "[Validation] Subject rating must be 1-5.\n";
        return false;
    }
    if (instructorRating < 1 || instructorRating > 5) {
        std::cerr << "[Validation] Instructor rating must be 1-5.\n";
        return false;
    }
    if (subjectCode.empty()) {
        std::cerr << "[Validation] Subject code cannot be empty.\n";
        return false;
    }
    if (instructor.empty()) {
        std::cerr << "[Validation] Instructor cannot be empty.\n";
        return false;
    }
    if (semester.empty()) {
        std::cerr << "[Validation] Semester cannot be empty.\n";
        return false;
    }
    if (comments.length() > 2000) {
        std::cerr << "[Validation] Comments too long.\n";
        return false;
    }
    return true;
}


bool StudentFeedback::submit() {
    if (!validate()) {
        std::cerr << "[Submit] Validation failed.\n";
        return false;
    }
    return true;
}

std::string StudentFeedback::getSubjectCode()      const { return subjectCode;      }
std::string StudentFeedback::getInstructor()       const { return instructor;       }
std::string StudentFeedback::getSemester()         const { return semester;         }
int         StudentFeedback::getInstructorRating() const { return instructorRating; }
