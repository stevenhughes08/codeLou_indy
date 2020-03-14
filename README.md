# SUITCASE OVERVIEW
> An app for organizing stage props to make my life easier. I am the primary intended audience and the members of the acting troupe that I am a member of. SUITCASE will take a list of theatrical ACTS that will have sublist of Props. Each prop will have five properties.

> > > **Optional Add on**. If a list of acts includes props the propgram can auto suggest a an act if the props are being packed. 

## FEATURES:

> **Admin Panel**
> > All CRUD functions are created from the ADMIN Panel. The admin panel is password protected. Admin can enter shows, ACTS, props and Performers


>**Shows**
 - Contains a list of ACTS
   - ID
   - Title
   - ACTS
  
>**ACTS**
- Contains a list of Props
    - ID
    - Title
    - Props
  
>**Props**
- ID
- Name
- location
- status: packed or unpacked
- Acts used in

>**Performer**
- ID
- Character Name
- List of ACTS

>**Output**
> Two views
> >**Set list:** shows a list of acts and performers in each act. This is printable. 
- Show Title
  - ACT
    - Performer1 
    - Performer2
    - performer3
    - performer4
  
> >**Packing List:** A list of acts and props.
- Shows Title
  - ACT 1
    - Prop 
    - Prop 
    - Prop
  - ACT 2
    - Prop
    - Prop
    - Prop
    - Prop

## TECHNICAL SUMMARY
- *** Backend: C# *** 
- *** FRAMEWORK: ASP.Net Core *** 
- *** FRONTEND: VUE/Bootstrap ***
- **DATABASE: SQL POSTGRES**
- **ORM: EF CORE**
- **SERVER: IIS**




## Milestones

- [x] Create a GitHub Repo and Start on a Project Plan

- [ ] Scaffold a new .NET Core MVC Application

- [ ] Model Relational [Example Project] Data

- [ ] Generating a Code First Database

- [ ] Creating CRUD Controllers

- [ ] Creating CRUD Views





