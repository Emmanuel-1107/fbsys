#ifndef FEEDBACK_H
#define FEEDBACK_H

#include <string>

class Feedback {
protected:
    int         feedbackID;
    std::string username;
    int         rating;
    std::string comments;
    std::string timestamp;
    std::string ipHash;

public:
    Feedback(const std::string& username,
             int rating,
             const std::string& comments,
             const std::string& ipHash);

    virtual ~Feedback() = default;

    virtual bool submit()   = 0;
    virtual bool validate() = 0;

    std::string sanitise(const std::string& input) const;

    int         getFeedbackID() const;
    std::string getUsername()   const;
    int         getRating()     const;
    std::string getComments()   const;
    std::string getTimestamp()  const;
    std::string getIpHash()     const;

    void setFeedbackID(int id);

private:
    std::string generateTimestamp() const;
};

#endif
