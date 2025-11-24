Freelance Project Management Platform

A C# MVC + MySQL freelance collaboration system that connects clients and freelancers from project posting to final review. Designed with clean separation of logic, modular classes, and practical workflow automation.

🚀 Features
Role Selection (Client / Freelancer)

Users choose a role via image buttons.
The selected role is stored in MySQL and passed to the registration page.

Project Posting (Client)

Clients can create projects with:

Title

Description

Budget

Deadline

Bid Submission (Freelancer)

Freelancers browse available projects and submit bids linked to their user ID.

Project Acceptance

Clients review bids and accept one freelancer.
Status changes to Accepted.

Deadline-Based Auto Completion

When a bid is accepted, the project's deadline becomes fixed.
When the date is reached, the system auto-updates status to Completed.

Freelancer Work Panel

Freelancers see:

Pending bids

Accepted projects

In-progress projects

Completed projects

Accepted projects include a Mark as Completed action.

Client Review System

Clients see completed projects in a card-style UI (FlowLayoutPanel):

⭐ Star rating

✏️ Comment

✔️ Submit review

🧱 Technical Stack

Frontend: Windows Forms (C#)
Backend: C# .NET using MVC structure
Database: MySQL

Structure

role.cs — pure model

class/ — business logic (project, bids, roles, deadlines)

review_projects.cs — review module

bid_projects.cs — freelancer project module

loginattempt_control.cs — login attempt handling

📦 Setup

1. Clone the repository.

2. Import the SQL schema into MySQL.

3. Configure the connection string in your DB handler or App.config.

4. Run the project from Visual Studio.

