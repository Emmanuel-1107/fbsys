#include "Feedback.h"
#include <algorithm>
#include <sstream>
#include <iomanip>
#include <ctime>
#include <regex>

Feedback::Feedback(const std::string& username,
                   int rating,
                   const std::string& comments,
                   const std::string& ipHash)
    : feedbackID(0),
      username(sanitise(username)),
      rating(rating),
      comments(sanitise(comments)),
      ipHash(ipHash)
{
    timestamp = generateTimestamp();
}

std::string Feedback::sanitise(const std::string& input) const {
    // Remove HTML/script tags for clean results
    std::string result = std::regex_replace(input, std::regex("<[^>]*>"), "");

    // Trim leading whitespace for clean results
    result.erase(result.begin(),
        std::find_if(result.begin(), result.end(),
            [](unsigned char c){ return !std::isspace(c); }));

    // Trim trailing whitespace for clean results
    result.erase(
        std::find_if(result.rbegin(), result.rend(),
            [](unsigned char c){ return !std::isspace(c); }).base(),
        result.end());

    return result;
}

std::string Feedback::generateTimestamp() const {
    std::time_t now = std::time(nullptr);
    std::tm* utc    = std::gmtime(&now);
    std::ostringstream oss;
    oss << std::put_time(utc, "%Y-%m-%dT%H:%M:%SZ");
    return oss.str();
}

int         Feedback::getFeedbackID() const { return feedbackID; }
std::string Feedback::getUsername()   const { return username;   }
int         Feedback::getRating()     const { return rating;     }
std::string Feedback::getComments()   const { return comments;   }
std::string Feedback::getTimestamp()  const { return timestamp;  }
std::string Feedback::getIpHash()     const { return ipHash;     }
void        Feedback::setFeedbackID(int id) { feedbackID = id;   }
