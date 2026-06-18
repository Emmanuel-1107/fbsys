#include "AdminUser.h"
#include <iostream>
#include <sstream>
#include <iomanip>
#include <ctime>
#include <random>
#include <functional>

AdminUser::AdminUser(int adminID,
                     const std::string& username,
                     const std::string& passwordHash,
                     const std::string& salt,
                     const std::string& role)
    : adminID(adminID),
      username(username),
      passwordHash(passwordHash),
      salt(salt),
      role(role),
      isLoggedIn(false),
      sessionToken("")
{}

bool AdminUser::login(const std::string& plainPassword) {
    if (isLoggedIn) {
        std::cout << "[Auth] Already logged in as " << username << "\n";
        return true;
    }
    if (hashPassword(plainPassword, salt) == passwordHash) {
        isLoggedIn   = true;
        sessionToken = generateSessionToken();
        lastLogin    = currentTimestamp();
        std::cout << "[Auth] Login successful: " << username << "\n";
        return true;
    }
    std::cerr << "[Auth] Login failed for: " << username << "\n";
    return false;
}

void AdminUser::logout() {
    isLoggedIn   = false;
    sessionToken = "";
    std::cout << "[Auth] " << username << " logged out.\n";
}

bool AdminUser::checkSession(const std::string& token) const {
    return isLoggedIn && !sessionToken.empty() && token == sessionToken;
}

std::string AdminUser::hashPassword(const std::string& plain,
                                    const std::string& s) const {
    // used hash for demo purposes
    std::size_t h = std::hash<std::string>{}(s + plain);
    std::ostringstream oss;
    oss << std::hex << std::setw(16) << std::setfill('0') << h;
    return oss.str();
}

std::string AdminUser::generateSessionToken() const {
    std::random_device rd;
    std::mt19937_64 eng(rd());
    std::uniform_int_distribution<uint64_t> dist;
    std::ostringstream oss;
    for (int i = 0; i < 4; ++i)
        oss << std::hex << std::setw(16) << std::setfill('0') << dist(eng);
    return oss.str();  // 64-char hex token
}

std::string AdminUser::currentTimestamp() const {
    std::time_t now = std::time(nullptr);
    std::tm* utc    = std::gmtime(&now);
    std::ostringstream oss;
    oss << std::put_time(utc, "%Y-%m-%dT%H:%M:%SZ");
    return oss.str();
}

int         AdminUser::getAdminID()      const { return adminID;      }
std::string AdminUser::getUsername()     const { return username;     }
std::string AdminUser::getRole()         const { return role;         }
std::string AdminUser::getLastLogin()    const { return lastLogin;    }
bool        AdminUser::getIsLoggedIn()   const { return isLoggedIn;   }
std::string AdminUser::getSessionToken() const { return sessionToken; }
