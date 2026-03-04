# Campus Event Management System

A cross-platform Campus Event Management System built using **Blazor WebAssembly** and **Firebase**.

This project was developed for the **SEN5001 – Mobile and Web Technologies module** at **Cardiff Metropolitan University**.

The system consists of two separate applications that share the same Firebase backend:

- **Student Application (EventManagementApp)** – browse events, RSVP, submit feedback, manage profile
- **Admin Application (EventManagementAdmin)** – manage events, view registrations, monitor feedback, dashboard statistics

---

## System Architecture
Students (Student App)
│
▼
Blazor WebAssembly Frontend
│
▼
JavaScript Interop
│
▼
Firebase Cloud Services
├── Authentication
├── Firestore Database
└── Firebase Storage
▲
│
▼
Administrators (Admin App)

Both applications communicate with the same Firebase backend, enabling real-time data synchronisation.

---

## Applications

### Student Application – EventManagementApp

| Feature | Description |
|------|-------------|
| Event Browsing | View events with category filtering and search |
| RSVP Registration | Register attendance for events |
| My RSVPs | View and manage personal RSVP history |
| Feedback Submission | Submit star rating (1–5) and comments |
| Event Calendar | Calendar view of campus events |
| Notifications | In-app notifications for event updates |
| Student Profile | Manage profile details and image |
| Authentication | Firebase Authentication (Email/Password) |

### Admin Application – EventManagementAdmin

| Feature | Description |
|------|-------------|
| Admin Dashboard | Real-time statistics (events, RSVPs, feedback, average rating) |
| Event Management | Create, edit, and delete events (CRUD) |
| View RSVPs | View all registrations across all events |
| View Feedback | View all submitted feedback with ratings |
| Event Calendar | Calendar view of all scheduled events |
| Admin Profile | Admin profile with image upload |
| Admin Authentication | Role-based access (admin users only) |

---

## Technology Stack

| Technology | Purpose |
|------|---------|
| Blazor WebAssembly | Frontend framework (C# + Razor components) |
| .NET 10 | Runtime environment |
| Firebase Firestore | Cloud NoSQL database |
| Firebase Authentication | Login and registration |
| Firebase Storage | Image upload and storage |
| Bootstrap 5 | Responsive UI framework |
| Bootstrap Icons | Icon library |
| JavaScript Interop | Bridge between C# and Firebase JS SDK |

---

## Project Structure

CampusEventManagementSystem/
├── EventManagementApp/ # Student Application
│ ├── Models/
│ ├── Pages/
│ ├── Layout/
│ └── wwwroot/
└── EventManagementAdmin/ # Admin Application
├── Models/
├── Pages/
├── Layout/
└── wwwroot/

---

## Firebase Database Collections

### events
Stores event information.

### rsvps
Stores student registrations.

### feedback
Stores feedback submissions.

### users
Stores user profile and role information (student/admin).

### notifications
Stores event update notifications.

---

## Setup Instructions

### Prerequisites
- Visual Studio 2022 (17.0+)
- .NET 10 SDK
- Firebase project (Authentication, Firestore, Storage enabled)

### Step 1: Create Firebase Project
1. Open Firebase Console: https://console.firebase.google.com
2. Create a new project
3. Enable **Authentication → Email/Password**
4. Create **Firestore Database**
5. Enable **Firebase Storage**
6. Get the `firebaseConfig` from Project Settings

### Step 2: Configure Firebase in Both Apps
Update Firebase config in:
- `EventManagementApp/wwwroot/index.html`
- `EventManagementAdmin/wwwroot/index.html`

Example:
```javascript
const firebaseConfig = {
  apiKey: "YOUR_API_KEY",
  authDomain: "your-project.firebaseapp.com",
  projectId: "your-project-id",
  storageBucket: "your-project.appspot.com",
  messagingSenderId: "123456789",
  appId: "1:123456789:web:abcdef123456"
};

Step 3: Set Up Admin Role in Firestore

Create a Firestore document for the admin user:
Collection: users
Document ID: <admin-user-uid>
Fields:
  - email: "admin@example.com"
  - role: "admin"
  - displayName: "Admin Name"
  - profileImageUrl: "" (optional)

Step 4: Run the Applications

Open EventManagementApp solution in Visual Studio → Press F5

Open EventManagementAdmin solution in Visual Studio → Press F5

Role-Based Access Control

Students access features via the Student App.

Admin users are verified using the users collection (role = "admin").

Non-admin users are blocked from admin-only pages.

Responsive Design

| Device  | Layout                                 |
| ------- | -------------------------------------- |
| Desktop | Sidebar + multi-column grids           |
| Tablet  | Collapsible navigation + 2-column grid |
| Mobile  | Hamburger menu + single-column layout  |

Validation and Error Handling

Email format validation

Required field validation

Minimum length validation

Rating must be 1–5

User-friendly messages on Firebase errors

Try/catch handling for Firebase operations

Developed for SEN5001 – Mobile and Web Technologies assessment at Cardiff Metropolitan University.
