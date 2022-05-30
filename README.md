# Kurs7 Systemtestning, Labb1  - MsUnit

## INTRODUCTION
This is a school assignment to create unit tests for a previous group assignment where we created a fictional bank. I have identified three parts of the code that are critical to the bank and that should be tested.

## PARTS TO TEST
### Transfer money between accounts
#### What could go wrong?
- Money doesn't withdraw from account. Method InternalTransfer() and ExternalTRansfer() in Bank class.
- Money doesn't go to the other account. Method InternalTransfer() and ExternalTRansfer() in Bank class.
- More money are transfered than what's available in the account. Method EnoughBalance() in Account.

### Withdraw money
#### What could go wrong?
- More money are withdrawn than what's available in the account. Method EnoughBalance() in Account.
- Money doesn't withdraw from account. Method Withdraw() in Bank.

### Log in
#### What could go wrong?
- A user can log in even though it doesn't exist in the system. Method CheckUserName() in User.
- The system can't find the user even though it exists in the system. Method CheckUserName() in User.
- A user can log in with incorrect password.
