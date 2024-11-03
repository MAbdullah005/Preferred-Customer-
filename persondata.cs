#include <iostream>
#include <string>

class PersonData :
   private string lastName;
   private string firstName;
   private string address;
   private string city;
   private string state;
   private   string zip;
   private string phone;

public:
    string getLastName() const 
    { 
        return lastName; 
    }
    string getFirstName() const 
    { 
        return firstName; 
    }
    string getAddress() const 
    { 
        return address; 
    }
    string getCity() const 
    { 
        return city; 
    }
    string getState() const 
    { 
        return state; 
    }
    string getZip() const 
    { 
        return zip; 
    }
    string getPhone() const 
    { 
        return phone; 
    }
    void setLastName(const string &ln) 
    { 
        lastName = ln; 
    }
    void setFirstName(const string &fn) 
    { 
        firstName = fn; 
    }
    void setAddress(const string &addr) 
    { 
        address = addr; 
    }
    void setCity(const string &c) 
    { 
        city = c; 
    }
    void setState(const string &s) 
    { 
        state = s; 
    }
    void setZip(const string &z) 
    { 
        zip = z; 
    }
    void setPhone(const string &p) 
    { 
        phone = p; 
    }
};
