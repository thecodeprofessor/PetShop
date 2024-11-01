# Pet Shop Console Application

This is a simple C# console application for managing a pet shop's inventory, allowing users to add, remove, list pets, and save/load data in JSON format.

## Project Overview
The PetShop application is designed to manage a pet store's inventory by allowing users to add, remove, list, and search for pets, all stored in a local JSON file. The application will be enhanced with SMS notifications that notify users when a pet's information is updated. Additionally, a CSV export feature will allow users to back up pet data.

---

## Team Members
- Alyx Vance (A00112233)
- Fox McCloud (A00223344)
- Gordon Freeman (A00334455)
- Samus Aran (A00445566)

---

## Features

- **Feature 1**: Basic CRUD operations for pet records (stored in a JSON file).
  - **Primary**: Alyx Vance
  - **Secondary**: Fox McCloud

- **Feature 2**: SMS notifications via Twilio when a pet's information is updated.
  - **Primary**: Gordon Freeman
  - **Secondary**: Samus Aran

- **Feature 3**: Search pets by name, species, or age.
  - **Primary**: Samus Aran
  - **Secondary**: Gordon Freeman

- **Feature 4**: Export pet inventory to a CSV file for backup.
  - **Primary**: Fox McCloud
  - **Secondary**: Alyx Vance

---

## Application Flow

1. **Step 1**: The user opens the application and is presented with a menu to choose an action (Add, Remove, List, Search, Export).
2. **Step 2**: The user performs actions based on menu options (e.g., adding a new pet or searching for a pet by name).
3. **Step 3**: If the Twilio SMS feature is enabled, the user receives SMS notifications when pet information is updated.
4. **Step 4**: The user can export the current pet inventory to a CSV file or exit the application.

---

## Agile Task Board (Progress Tracker)
The following section should be updated by each student as they perform work on the project. Items should begin as sub-items under the 'Backlog (Not Started)' heading and progressively be moved to subsequent sections as work is undertaken and completed. This board helps the team visualize project progress, ensuring that tasks move smoothly from planning to completion. This type of organizational board is commonly represented in a table style and is often referred to as a Kanban Board or a Scrum Board.

### Backlog (Not Started)
- Validation - Refactor AddPet() to validate pet details. (Alyx)
  - Validate pet name (non-empty). (Alyx)
  - Validate pet age (positive integer). (Alyx)
  - Validate price (positive value). (Alyx)
  - Validate species and color (non-empty). (Alyx)
- Confirmation - Improve RemovePet() to display confirmation before deletion. (Fox)
  - Display confirmation prompt. (Fox)
  - Handle user response (yes/no). (Fox)
- Pet Price Validation - Ensure that price entered is a positive value. (Alyx)
- Add Color Filter - Add filter functionality to search pets by color. (Samus)
- User Manual - Create a user manual for the application. (Fox)
  - Write instructions for setup and installation. (Fox)
  - Document main menu functionalities. (Fox)
  - Add troubleshooting section. (Fox)
  - Include a FAQ section for common user questions. (Fox)
- Setup Continuous Integration - Set up GitHub Actions for continuous integration. (Gordon)
  - Define build workflow. (Gordon)
  - Add automated testing. (Gordon)
  - Configure notifications on build failure. (Gordon)
- Code Comments - Add XML code comments for methods. (Samus)
  - Comment AddPet() method. (Samus)
  - Comment RemovePet() method. (Samus)
  - Comment LoadPets() method. (Samus)
- Check-In Meeting 2 - Meet with professor to discuss final progress. (Alyx)
  - Verify all team members are committing regularly to GitHub. (Alyx)
  - Verify both code and README.md task board are being updated. (Alyx)
  - Prepare a list of pending tasks and next steps. (Alyx)
- Final Presentation - Prepare and present the application to the professor. (All)
  - Prepare a PowerPoint presentation. (All)
  - Verify the application works without errors. (All)
  - Brainstorm and make a backup plan for technical problems. (All)
  - Assign presentation roles to each team member. (All)
  - Practice the presentation. (All)
  - Present to the professor. (All)
- Final Code Submission - Submit the final version of the code. (All)
  - Ensure code is fully tested. (All)
  - Submit via GitHub. (All)
  - Notify professor of submission. (All)

### In Progress (Currently Being Worked On)
- Load Pets - Implement functionality to load pets from pets.json. (Alyx)
  - Load JSON file. (Alyx)
  - Deserialize JSON data. (Alyx)
  - Handle file not found exceptions. (Alyx)
- Save Pets - Implement functionality to save pets to pets.json. (Fox)
  - Serialize pet data to JSON. (Fox)
  - Save JSON data to file. (Fox)
  - Handle file write exceptions. (Fox)
  - Verify data is correctly formatted before saving. (Fox)
- Search Species/Age - Implement search by pet species and age. (Samus)
  - Implement species search functionality. (Samus)
  - Implement age search functionality. (Samus)
  - Test search feature with sample data. (Samus)
- Search Name - Implement search by pet name functionality. (Gordon)
  - Add search input prompt. (Gordon)
  - Implement search algorithm. (Gordon)
  - Test edge cases (e.g., partial matches). (Gordon)
  - Verify case-insensitive search functionality. (Gordon)
- User Interface Enhancements - Improve console user interface for better clarity. (Fox)
  - Update menu layout for readability. (Fox)
  - Add spacing and alignment for better visual appearance. (Fox)
  - Add color coding for menu options to improve UX. (Fox)
- Exception Handling - Implement proper exception handling for user inputs. (Alyx)
  - Handle invalid menu selection. (Alyx)
  - Handle non-integer age input. (Alyx)
  - Handle non-numeric price input. (Alyx)
  - Log exceptions for troubleshooting. (Alyx)
- Data Persistence - Ensure data is saved automatically after each operation. (Fox)
  - Add save functionality after AddPet(). (Fox)
  - Add save functionality after RemovePet(). (Fox)
  - Verify saved data integrity after each modification. (Fox)

### In Review
- Twilio Setup - Set up Twilio API and acquire necessary credentials. (Gordon)
  - Acquire Twilio credentials. (Gordon)
  - Implement SMS sending functionality. (Gordon)
  - Test SMS notifications with dummy data. (Gordon)
  - Verify SMS notifications for different scenarios (e.g., pet addition, removal). (Gordon)
- CSV Validation - Validate and format CSV data output. (Alyx)
  - Check for correct CSV format. (Alyx)
  - Validate data fields (no empty fields). (Alyx)
  - Test CSV export with sample data. (Alyx)
- SMS Notifications - Implement SMS notifications for pet updates. (Gordon)
- CSV Export - Implement method to export pet records to CSV. (Fox)
- Pet Removal Confirmation - Add a confirmation prompt before removing a pet. (Fox)
- Code Review - Review and optimize the search functionalities. (Alyx)
- Data Load Efficiency - Improve efficiency of loading pets from JSON. (Samus)
  - Optimize JSON reading logic. (Samus)
  - Test loading with large datasets. (Samus)

### Completed
- Add Pet Functionality - Basic functionality to add a pet to the inventory. (Alyx)
- List Pets - Display a list of all pets in the inventory. (Fox)
- Remove Pet Functionality - Basic functionality to remove a pet from the inventory. (Gordon)
- Save Pets to JSON - Implement saving pet data to JSON file upon exit. (Fox)
  - Serialize pet data to JSON format before saving. (Fox)
  - Test saving with multiple pet records. (Fox)
  - Verify saved file content is correct. (Fox)
- Load Pets from JSON - Load pet data from a JSON file when the application starts. (Alyx)
  - Load JSON data at application start. (Alyx)
  - Verify data loaded matches previously saved records. (Alyx)
- Check-In Meeting 1 - Meet with professor to discuss progress. (Samus)
  - Verify all team members are committing regularly to GitHub. (Samus)
  - Verify both code and README.md task board are being updated. (Samus)
  - Identify and discuss any blockers. (Samus)

---

## Console User Interfaces

### Main Menu

```text
+-----------------------------+
| Welcome to PetShop App       |
| 1. Add a Pet                 |
| 2. Remove a Pet              |
| 3. List Pets                 |
| 4. Search Pets               |
| 5. Export Pets to CSV        |
| 6. Exit                      |
+-----------------------------+
```

### Add Pet Screen

```text
+-----------------------------+
| Add a New Pet                |
| Please enter the following:  |
| Name:                        |
| Species:                     |
| Age:                         |
| Price:                       |
| Color:                       |
+-----------------------------+
```

### Search Pets Screen

```text
+-----------------------------+
| Search Pets                  |
| 1. Search by Name            |
| 2. Search by Species         |
| 3. Search by Age             |
+-----------------------------+
```
