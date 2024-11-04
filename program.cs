int main() {
    PreferredCustomer preferredCustomer;

    preferredCustomer.setLastName("Smith");
    preferredCustomer.setFirstName("Jane");
    preferredCustomer.setAddress("456 Oak St");
    preferredCustomer.setCity("Othertown");
    preferredCustomer.setState("TX");
    preferredCustomer.setZip("75001");
    preferredCustomer.setPhone("555-5678");
    preferredCustomer.setCustomerNumber(2001);
    preferredCustomer.setMailingList(true);
    preferredCustomer.setPurchasesAmount(1500);

    cout << "Preferred Customer Information:" << endl;
    cout << "Name: " << preferredCustomer.getFirstName() << " " << preferredCustomer.getLastName() << endl;
    cout << "Address: " << preferredCustomer.getAddress() << ", " << preferredCustomer.getCity() << ", "
         << preferredCustomer.getState() << " " << preferredCustomer.getZip() << endl;
    cout << "Phone: " << preferredCustomer.getPhone() << endl;
    cout << "Customer Number: " << preferredCustomer.getCustomerNumber() << endl;
    cout << "Mailing List: " << (preferredCustomer.isOnMailingList() ? "Yes" : "No") << endl;
    cout << "Purchases Amount: $" << preferredCustomer.getPurchasesAmount() << endl;
    cout << "Discount Level: " << preferredCustomer.getDiscountLevel() << "%" << endl;

    return 0;
}
