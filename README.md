# Kurs7 Systemtestning, Labb1  - MsUnit

## INTRODUCTION
This is a school assignment to create unit tests for a previous group assignment where we created a fictional bank. I have identified three parts of the code, 
which in my opinion is the most important parts of the bank, that should be tested.

## TABLE OF CONTENTS

## Parts to test
### Transfer money between accounts
#### What could go wrong?
- Money doesn't withdraw from account. Method MakeTransfer() in Account.
- Money doesn't go to the other account. Method MakeTransfer() in Account.
- More money are transfered than what's available in the account. Method EnoughBalance() in Account.

### Withdraw money
#### What could go wrong?
- More money are withdrawn than what's available in the account. Method EnoughBalance() in Account.
- Money doesn't withdraw from account. Method Withdraw() in Bank.

### Deposit money
#### What could go wrong?
- Money isn't deposited to account. Method Deposit() in Bank.
