# Campus-Managemnt-api
# 🎓 Campus Management System

## 📝 Overview

Campus Management System is a robust and scalable web application designed to streamline educational institution operations. Built with modern technologies, it provides comprehensive management of students, courses, enrollments, and administrative tasks.

## 🚀 Technology Stack

- **Backend Framework**: ASP.NET 
- **Database**: MongoDB
- **Authentication**: ASP.NET Core Identity
- **ORM**: MongoDB.Driver

## ✨ Key Features

### 🔐 Authentication and Authorization
- Comprehensive role-based access control
- Secure endpoints with JWT authentication
- Granular user role permissions (Admin, Instructor, Student)

### 📚 Enrollment Management
- Seamless enrollment creation
- Automatic active status assignment
- Advanced grade tracking with letter grades
- Intelligent grade assignment restrictions

## 🗂️ System Architecture

### 📊 Core Models

#### 1. Student Model
- Comprehensive student information tracking
- Direct linkage to enrollments and courses
- Supports detailed student profile management

#### 2. Course Model
- Detailed academic course representation
- Department and instructor associations
- Course-specific metadata management

#### 3. Enrollment Model
- Robust student-course relationship management
- Flexible grade and status tracking
- Supports multiple grade types:
  - Academic Grades: A, B, C, D, F
  - Special Statuses: I (Incomplete), W (Withdrawn), IP (In Progress)

#### 4. Department Model
- Manage academic departments and courses
- Department-specific metadata management

#### 5. Instructor Model
- Comprehensive instructor information tracking
- Course and department associations


## 🔒 Authorization Hierarchy

### 👑 Admin
- Full system access
- Unrestricted CRUD operations
- User management
- System configuration

### 👩‍🏫 Instructor
- Course and enrollment management
- Grade assignment
- Student performance tracking

### 🧑‍🎓 Student
- View personal enrollments
- Limited read-only access
- Self-service capabilities


## 📦 Installation

### Prerequisites
- .NET SDK
- MongoDB
- VS Code

### Setup Steps
1. Clone the repository
2. Configure `appsettings.json`
3. Restore dependencies: `dotnet restore`
4. Launch application: `dotnet run`

## 🔐 Security Implementations
- JWT-based authentication
- Role-based access control
- Secure endpoint design
- Protected database operations
- Encryption of sensitive data

## 🛠️ Configuration

### MongoDB Setup
Configure your database connection in `appsettings.json`:

```json
{
  "MongoDB": {
    "ConnectionString": "mongodb://localhost:27017",
    "DatabaseName": "CampusManagementSystem"
  }
}

