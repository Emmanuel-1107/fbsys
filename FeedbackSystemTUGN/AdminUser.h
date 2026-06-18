#ifndef ADMIN_USER_H
#define ADMIN_USER_H

#include <string>

class AdminUser {
private:
    int         adminID;
    std::string username;
    std::string passwordHash;
    std::string salt;
    std::string lastLogin;
    std::string role;
    bool        isLoggedIn;
    std::string sessionToken;

public:
    AdminUser(int adminID,
              const std::string& username,
              const std::string& passwordHash,
              const std::string& salt,
              const std::string& role = "admin");

    bool login(const std::string& plainPassword);
    void logout();
    bool checkSession(const std::string& token) const;

    int         getAdminID()      const;
    std::string getUsername()     const;
    std::string getRole()         const;
    std::string getLastLogin()    const;
    bool        getIsLoggedIn()   const;
    std::string getSessionToken() const;

private:
    std::string hashPassword(const std::string& plain,
                             const std::string& salt) const;
    std::string generateSessionToken() const;
    std::string currentTimestamp()     const;
};

#endif
