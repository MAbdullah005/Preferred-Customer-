class PreferredCustomer : public CustomerData {
private:
    double purchasesAmount;
    double discountLevel;

public:
    PreferredCustomer() 
        : purchasesAmount(0), discountLevel(0) 
    {}

    double getPurchasesAmount() const 
    { 
        return purchasesAmount; 
    }
    
    double getDiscountLevel() const 
    { 
        return discountLevel; 
    }

    void setPurchasesAmount(double amount) 
    {
        if (amount < 0) {
            cerr << "Invalid purchase amount. Must be non-negative." << endl;
            return;
        }
        purchasesAmount = amount;
        updateDiscountLevel();
    }

private:
    void updateDiscountLevel() 
    {
        if (purchasesAmount >= 2000) {
            discountLevel = 10;
        } else if (purchasesAmount >= 1500) {
            discountLevel = 7;
        } else if (purchasesAmount >= 1000) {
            discountLevel = 6;
        } else if (purchasesAmount >= 500) {
            discountLevel = 5;
        } else {
            discountLevel = 0;
        }
    }
};
