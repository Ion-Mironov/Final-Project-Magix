# C#/.NET Final Project: Magix
Final Project focused on creating a card shop owner solution to automatically update stock databases when dealing with trade-ins.


## Final group project pitch:

***Brick & Mortar trade-in solution***
<br>
Full Grip Games located in Akron, Ohio, has a website that is almost never up-to-date with Magic: The Gathering card stock status.
This is counter-productive, as it is easier to check the stock than to travel to the store and ask if they have it in stock.

To solve this, I would like to build a section of their website for them that allows employees to record a stack of cards on the new page, and as they add a card name, they are given a clickable list of potential cards to add. Once the card name is decided upon, the user can select the ***Condition***, ***Print***, ***Set***, and ***Foil/Non-foil*** details. The user would then click "**Add to Trade-in**", and the form would clear to accept the next card.

As the list is populated, a running total of Market Value for the entire list would be pulled from the Scryfall.io API. We would then adapt the trade-in value of (cash) 50% or (store-credit) 65%. If the customer is okay with the terms, we would click a button to confirm the trade-in. This action would then push the obtained cards into the database, updating it in real-time, solving the issue of a not-up-to-date stock information for customers.


### Features required:
- API Consumption
- ASP.NET MVC
- ASP.Net Core
- ASP.NET Entity Framework
- Database Queries / Updates
- C#
- Html
- CSS
- Javascript

We can also turn this into an SAAS to market to other locations.
