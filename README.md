> **Malicious Pattern Detector Web Service**

This project provides a web service for detecting malicious patterns in user-submitted scripts. It scans the input scripts for predefined patterns such as SQL injection, XSS, and shell command attacks, helping ensure safer handling of user inputs.

**Features**
Detects the following malicious patterns:
SQL injection patterns like SELECT * and DROP TABLE.
XSS attack patterns like <script>.
Shell command attacks like rm -rf.
Simple interface to check if a script is malicious or safe.

**Technologies Used**
ASP.NET Web Forms (using .asmx web service)
C#

**Getting Started**
Follow these steps to set up and run the project.
Prerequisites
Visual Studio (2019 or later)
.NET Framework (4.x or later)
