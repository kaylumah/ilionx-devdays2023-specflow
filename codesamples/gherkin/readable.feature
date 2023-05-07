Given an open account with 100 USD balance
When the account receives a 20 USD payment
Then the account balance will be 120 USD

Given a <status> account with <old balance> balance
When the account receives an <amount> payment
Then the account balance will be <new balance>

Examples:

| status | old balance | amount | new balance |
| open   | 100 USD     | 20 USD |     120 USD | 


Given an "open" account with "100 USD" balance
When the account receives a payment of "20 USD"
Then the account balance will be "120 USD"