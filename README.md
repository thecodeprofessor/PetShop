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

## Task Board (Agile Progress Tracker)

### Backlog (Not Started)
- **Validation**: Refactor `AddPet()` to validate pet details. (Alyx)
- **Confirmation**: Improve `RemovePet()` to display confirmation before deletion. (Fox)
- **Twilio Setup**: Set up Twilio API and acquire necessary credentials. (Gordon)

### In Progress (Currently Being Worked On)
- **SMS Notifications**: Implement SMS notifications for pet updates. (Gordon)
- **CSV Export**: Implement method to export pet records to CSV. (Fox)

### In Review
- **CSV Validation**: Validate and format CSV data output. (Alyx reviewing Fox's work)
- **Search Species/Age**: Implement search by pet species and age. (Gordon reviewing Samus's work)
- **Search Name**: Implement search by pet name functionality. (Gordon reviewing Samus's work)

### Completed
- **Load Pets**: Implement functionality to load pets from `pets.json`. (Alyx)
- **Save Pets**: Implement functionality to save pets to `pets.json`. (Fox)

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
