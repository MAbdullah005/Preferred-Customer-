class CustomerData : public PersonData {
private:
    int customerNumber;
    bool mailingList;

public:
    int getCustomerNumber() const 
    { 
        return customerNumber; 
    }
    
    bool isOnMailingList() const 
    { 
        return mailingList; 
    }

    void setCustomerNumber(int number) 
    { 
        customerNumber = number; 
    }
    
    void setMailingList(bool ml) 
    { 
        mailingList = ml; 
    }
};
