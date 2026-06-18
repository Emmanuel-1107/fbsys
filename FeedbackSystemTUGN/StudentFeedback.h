#ifndef STUDENT_FEEDBACK_H
#define STUDENT_FEEDBACK_H

#include "Feedback.h"

class StudentFeedback : public Feedback {
private:
    std::string subjectCode;
    std::string instructor;
    std::string semester;
    int         instructorRating;

public:
    StudentFeedback(const std::string& username,
                    int subjectRating,
                    const std::string& comments,
                    const std::string& ipHash,
                    const std::string& subjectCode,
                    const std::string& instructor,
                    const std::string& semester,
                    int instructorRating = 0);

    bool submit()   override;
    bool validate() override;

    std::string getSubjectCode()     const;
    std::string getInstructor()      const;
    std::string getSemester()        const;
    int         getInstructorRating() const;

private:
    bool isValidSubjectCode(const std::string& code) const;
    bool isValidSemester(const std::string& sem)     const;
};

#endif
