# SUITCASE: An app for organizing stage props

## What are the goals of the App?


### Core functionality


#### Input
- Site will need an admin screen
  - Admin screen will be able to enter accept and delete data in the database. 
  - Admin will be able to CRUD Acts and props
    - Each Act will *contain* a list of props
  
  
#### Output
- APP will output a list of acts and props
- If props are included in multiple acts they will need to have an * next to them.
- Act will need to be maintained in a `list`
- Props will be in a sub list
- Once acts are added to the new list, props will be added as well.

> Output should look like this
>> ACT 1
    - prop
    - prop 
    - prop 
    - prop

>> ACT 2
    - prop 
    - prop
    - prop
    - prop
    - prop
  
>> Your show includeds **ACT 1** and **ACT 2**, these acts share *props* with **ACT 7**, **ACT 14** and **ACT 22**
>> Do you want to include this act YES/NO



#### Basic functionality
- Take a list of acts and output a packing list of props.
- Each item on the list will need to have two states, packed and not packed.
- The user will need to be able to click the item to change the state from not packed to packed. 




#### Fun Functionality
- Examine all props on the packing list: `if` all props included are listed in another act `then` suggest act to be included. 

>>The following props are `print list` are included in `print act`. `Click here` to add this act to the packing list.



# The Tech Stack I intend to use
- I plan on using .Net Core for the backend with an MVC design pattern
- The view layer will be created using VUE
- The Data layer will either postgres or google Firebase.







