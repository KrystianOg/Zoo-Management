# **Zoo-Management**
Wroclaw University of Technology BD1 course (Data Bases 1) project. It contains tool for managing a zoo (Windows App with GUI) connected to Relational Database.

Database tables:

--- | Employees | ---
--- | --- | --- 
PK | Employee_ID | CHAR(36)
--- | --- | --- 
--- | name | VARCHAR2(32)
--- | --- | --- 
--- | last_name | VARCHAR2(32)
--- | --- | --- 
--- | birth_date | DATE
--- | --- | --- 
FK | position_name | VARCHAR2(255)
--- | --- | --- 
--- | email | VARCHAR2(255)
--- | --- | --- 
--- | password | VARCHAR2(64)
--- | --- | --- 
--- | email_verification | BOOLEAN

--- | Positions | ---
--- | --- | --- 
PK | Position_name | VARCHAR(255)
--- | --- | --- 
--- | salary | DOUBLE
--- | --- | --- 
--- | responsibility | TEXT

--- | Animals_types | ---
--- | --- | --- 
PK | Animal_type_ID | CHAR(36)
--- | --- | --- 
--- | name | VARCHAR2(255)
--- | --- | --- 
--- | description | TEXT
--- | --- | --- 
FK | Food_ID | CHAR(36)
--- | --- | --- 
--- | food_amount | DOUBLE
--- | --- | --- 
--- | family | VARCHAR(64)

--- | Animals | ---
--- | --- | --- 
PK | Animal_ID | CHAR(36)
--- | --- | --- 
--- | name | VARCHAR2(32)
--- | --- | --- 
--- | weight | DOUBLE

--- | Food| ---
--- | --- | --- 
PK | Food_ID | CHAR(36)
--- | --- | --- 
--- | Food_type | VARCHAR(64)
--- | --- | --- 
--- | price | DOUBLE
--- | --- | --- 
--- | expiry_date | DATETIME

--- | Storage | ---
--- | --- | --- 
PK | Storage_ID | CHAR(36)
--- | --- | --- 
FK | Food_ID | CHAR(36)
--- | --- | --- 
--- | Row_ID | CHAR(1)
--- | --- | --- 
--- | Pos_ID | INT
--- | --- | --- 
--- | Shelf | INT
--- | --- | --- 

--- | Log | ---
--- | --- | --- 
PK | Log_ID | CHAR(36)
--- | --- | --- 
--- | time | DATETIME
--- | --- | --- 
--- | message | VARCHAR(255)
--- | --- | --- 
