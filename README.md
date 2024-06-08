# AR Construction Visualization Tool

## Introduction

Traditional building design methods are manual and time-consuming, relying heavily on physical models, 2D/3D drawings, and physical materials. This project aims to streamline and enhance the construction visualization process by integrating Building Information Modeling (BIM), Augmented Reality (AR), and Virtual Reality (VR) technologies. Our app allows for immersive 3D model creation, real-time design modifications, and improved collaboration among architects, builders, and stakeholders.

## Abstract

- **Traditional Design Methods:** Paper plans, blueprints, CAD.
- **Visualization Tools:** Physical models, 2D/3D drawings.
- **Challenges:** Costly changes and time-consuming modifications during the construction phase.
- **Project Goal:** Develop an automated construction visualization tool.
- **Mobile App Development:** Integrate AR and VR for complete building and interior visualization.

## Vision, Mission, and Objectives

- **Vision:** A user-friendly AR app that simplifies construction processes, enhances understanding, and improves decision-making.
- **Mission:** Revolutionize the construction industry with a cutting-edge AR tool that transforms traditional views and alters industry norms.
- **Objectives:**
  - Simplify design and planning processes.
  - Provide immersive 3D model visualization.
  - Enhance real-time collaboration.
  - Increase efficiency and reduce costs.
  - Foster innovation through AR and VR technologies.

## Problem Statement

Design, develop, and implement an automated tool to visualize the construction of buildings, addressing the limitations of traditional methods and providing an immersive, interactive experience.

## Software Requirements

- **Unity 3D Game Engine:** For creating and deploying 3D content.
- **AR Development SDK (Vuforia):** For integrating AR capabilities.
- **3D Modelling Software (Blender, Maya):** For creating detailed 3D models.
- **Version Control System (Git):** For managing code changes and collaboration.
- **Mobile App Development Tools (Android Studio):** For developing, testing, and deploying the mobile app on Android devices.

## Implementation of the Modules

1. **Login & Registration:**
   - **Input:** User credentials (username, password).
   - **Process:** Validate and authenticate credentials.
   - **Output:** Authenticated user session with access to app functionalities.

2. **Developer Contacts:**
   - **Input:** Developer contact details (email, phone number, etc.).
   - **Process:** Display contact information in the app.
   - **Output:** Visible contact details for user support.

3. **Select 3D Model:**
   - **Input:** List of available 3D models.
   - **Process:** Allow users to browse and select a desired 3D model.
   - **Output:** Selected 3D model for further interaction.

4. **Marker-based Augmented Reality:**
   - **Input:** Selected 3D model and AR marker.
   - **Process:** Activate camera for marker-based AR tracking, recognize and track the marker, and overlay the 3D model.
   - **Output:** AR view displaying the 3D model overlaid on the marker.

5. **Augmented Reality Portal:**
   - **Input:** Selected 3D model.
   - **Process:** Display a virtual portal door in the AR environment, allow users to interact with the portal door, and transition to a view displaying the 3D model inside the portal.
   - **Output:** AR view showing the 3D model inside the virtual portal door.

## Getting Started

### Prerequisites

- Unity 3D Game Engine
- Vuforia SDK
- Blender or Maya for 3D modeling
- Git for version control
- Android Studio for mobile app development

### Installation

1. **Clone the Repository:**
   ```sh
   git clone https://github.com/yourusername/AR-Construction-Visualization.git
   cd AR-Construction-Visualization
