# TrelloClone by Zahoor Shah
[![Build Trello](https://github.com/imzahoorshah/TrelloClone/actions/workflows/build.yml/badge.svg)](https://github.com/imzahoorshah/TrelloClone/actions/workflows/build.yml)

# Event Sourcing and CQRS Examples
Problem statement 3: Trello Clone

We are building an enhanced trello.com clone which will allow users to collaborate over a shared board. Every board has multiple columns. Users can create / update / delete "cards". They can also move cards between columns. Cards can have one more or labels
Our clone allows users to do a new functionality. When a user visits a board it also highlights cards which have been created / modified since the last time they accessed the board. This allows the users to quickly understand what has changed
Write a service to

  •	output the board as a JSON message
  
  •	Build a search service to list all cards containing a tag
  
  •	Build a search service to list all cards in a column
  
  •	Build a service to list all cards created after a given timestamp
  
  •	Build a service to lists all the cards which should be highlighted for a user

![image](https://user-images.githubusercontent.com/114560719/193041400-93587249-2692-440c-81ea-90763ff16feb.png)


## Domain overview
In this minimalistic bank, a _client_ can _open_ one or more _accounts_.  
On each _account_, the _client_ can _deposit_ or _withdraw_ money.  
The history of an _account's transactions_ is available to the _client_ as well as a summary of the _client's accounts_.

## Design choices
### CQRS


### Note
This application is written in .NET 5.
Once you build this application, go to the package manager console and run add-migration TrelloSchema-2
Run the application and it will open with swagger for testing.
Insert some data using post method.
And run the tested cases outlined in the BAC.

Thanks :)

 

# License
This project is distributed under the no (LICENSE).
