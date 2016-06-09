#The LateRooms Group full-stack task

Please take as much time as you see appropriate to tackle this task. Your solution will be the basis for a discussion during our interview.

##The task

The aim of the kata is to create a basic application to allow a user to record a list of cities they would like to visit.
The initial list should be served up from an endpoint that you create and should use the following JSON data:

```json
[
  {
    "City": "Manchester",
    "Country": "UK",
    "Attractions": ["football", "bars", "music"]
  },
  {
    "City": "York",
    "Country": "UK",
    "Attractions": ["city walls", "cathedral"]
  },
  {
    "City": "Las Vegas",
    "Country": "USA",
    "Attractions": ["casinos","Grand Canyon","shows"]
  },
  {
    "City": "Beijing",
    "Country": "China",
    "Attractions": ["Great Wall of China", "Forbidden City"]
  }
]
```

You should then create a basic web application and add as many of the following pieces of functionality as you have time to:

1. List all the cities retrieved from the endpoint you created
2. Ability to add a new city to the list
    * Provide basic validation
3. Allow a user to mark a city as visited/unvisited
4. Show a visual counter of a number of cities visited/unvisited
5. Filter the cities by state (i.e. visited or unvisited)
6. Sort the cities by state (i.e. visited or unvisited)

You should aim to complete as many of these things as possible, demonstrating a good understanding of architecture, design and best practice.
__Strong Testing methodologies (TDD and/or BDD) should be used.__