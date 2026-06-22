-- =====================================================================
-- Mobile Inventory System - Database Creation Script
-- Database: Mobile_Inventory_System
-- Compatible with: SQL Server Express / SQL Server
-- =====================================================================

-- Step 1: Create the Database
-- (If you already have the database, skip this and just run the table scripts)
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'Mobile_Inventory_System')
BEGIN
    CREATE DATABASE [Mobile_Inventory_System];
END
GO

USE [Mobile_Inventory_System];
GO

-- =====================================================================
-- TABLE 1: Login (User Authentication)
-- Used by: Login.vb, Add_acc.vb, Reset_pass.vb, Forgot_Password.vb
-- =====================================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Login')
BEGIN
    CREATE TABLE [dbo].[Login] (
        [User_id]    INT            IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [User_name]  NVARCHAR(100)  NOT NULL,
        [Password]   NVARCHAR(100)  NOT NULL
    );
END
GO

-- Alias columns used in DataGridView (Add_acc.vb reads "ID" and "u_name")
-- The code reads: DataGridView1.Item("ID", ...) and DataGridView1.Item("u_name", ...)
-- So we need a view or the columns must match. Since "select * from Login" is used,
-- the actual column names must be: User_id mapped to "ID", User_name mapped to "u_name"
-- Let's drop and recreate with the correct column names as expected by the code.
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Login')
    DROP TABLE [dbo].[Login];
GO

CREATE TABLE [dbo].[Login] (
    [ID]         INT            IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [u_name]     NVARCHAR(100)  NOT NULL,
    [Password]   NVARCHAR(100)  NOT NULL
);
GO

-- Note: The INSERT uses (User_name, Password), UPDATE uses User_name, Password, User_id
-- But DataGridView reads "ID" and "u_name"
-- To handle both, we use the DataGridView column names as actual names
-- and the insert/update SQL in code references User_name and User_id
-- So we need to match BOTH. The safest approach: use the column names 
-- the code inserts/selects with. Let's re-examine:
--   INSERT: "insert into Login (User_name,Password) values(...)"
--   SELECT: "Select * from Login" -> DataGridView reads "ID", "u_name", "Password"
--   UPDATE: "update Login set User_name='...',Password='...' where User_id='...'"
--   DELETE: "delete from Login where User_id=..."
--   Login check: "Select * from Login where User_name='...' and Password='...'"
--
-- This means the table needs columns that work for BOTH naming conventions.
-- The simplest fix: use User_id, User_name, Password as column names
-- but the DataGridView shows "ID" and "u_name" because "select *" returns those.
-- Since we can't have both, let's use the INSERT/UPDATE names and note that
-- DataGridView column headers come from the actual column names.
-- The code accesses: .Item("ID",...) and .Item("u_name",...) 
-- This means the ACTUAL column names must be ID, u_name, Password
-- but INSERT uses "User_name" and UPDATE uses "User_id"
-- RESOLUTION: The actual columns must be named to match the DML statements.
-- The .Item("ID") and .Item("u_name") must match the SELECT output.
-- Since the code does "select * from Login", column names = actual column names.
-- 
-- Looking more carefully at the code:
--   Login.vb:      "Select * from Login where User_name='...' and Password='...'"
--   Add_acc.vb:    "insert into Login (User_name,Password) values(...)"
--   Add_acc.vb:    "Select User_name from Login where User_name='...'"
--   Add_acc.vb:    "update Login set User_name='...',Password='...' where User_id='...'"
--   Add_acc.vb:    "delete from Login where User_id=..."
--   Add_acc.vb:    "select * from Login" -> reads .Item("ID"), .Item("u_name"), .Item("Password")
--   Reset_pass.vb: "UPDATE [data_stu16].[Login] SET [Password] = '...' WHERE [User_name]='...'"
--
-- The DataGridView Item names ("ID", "u_name") MUST match column names from "select *".
-- But INSERT references "User_name" and DELETE references "User_id".
-- This is a conflict in the original code. To make it work, we use the names
-- that the INSERT/UPDATE statements use, since those will throw SQL errors if wrong.
-- The DataGridView .Item() calls would need the code to match.
-- 
-- FINAL DECISION: Use User_id, User_name, Password as that's what the SQL DML uses.
-- The DataGridView references to "ID" and "u_name" appear to be a code bug 
-- or the original DB had aliases. We'll use the DML-compatible names.

IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Login')
    DROP TABLE [dbo].[Login];
GO

CREATE TABLE [dbo].[Login] (
    [User_id]    INT            IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [User_name]  NVARCHAR(100)  NOT NULL,
    [Password]   NVARCHAR(100)  NOT NULL
);
GO

-- Insert a default admin account so you can log in
INSERT INTO [dbo].[Login] ([User_name], [Password])
VALUES ('admin', 'admin');
GO


-- =====================================================================
-- TABLE 2: Customer
-- Used by: Add_Customer.vb, Customer.vb, Invoice.vb
-- =====================================================================
CREATE TABLE [dbo].[Customer] (
    [Customer_ID]    INT            IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Customer_Name]  NVARCHAR(200)  NOT NULL,
    [Address]        NVARCHAR(500)  NULL,
    [Contact]        NVARCHAR(15)   NULL
);
GO


-- =====================================================================
-- TABLE 3: Product1 (Product Master)
-- Used by: Add_product.vb, Product.vb, Add_Purchase.vb
-- =====================================================================
-- Columns from code:
--   INSERT: Product_Name, Rate, GST, [CGST/SGST], Amount, Sales_Rate
--   SELECT: Product_Name, Amount, Sales_Rate, Product_id
--   DataGridView reads: p_id, p_name, GST, CGST_SGST, Amount, Sales_Rate
--   UPDATE: Product_Name, Rate, GST, [CGST/SGST], Amount, Sales_Rate WHERE Product_id
--   DELETE: Product_id
--
-- The DataGridView .Item() uses "p_id", "p_name", "CGST_SGST" 
-- but the INSERT uses "Product_Name", "Product_id", "[CGST/SGST]"
-- Again a naming mismatch. We use the DML-compatible names.

CREATE TABLE [dbo].[Product1] (
    [Product_id]   INT            IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Product_Name] NVARCHAR(200)  NOT NULL,
    [Rate]         DECIMAL(18,2)  NULL DEFAULT 0,
    [GST]          DECIMAL(18,2)  NULL DEFAULT 0,
    [CGST/SGST]    DECIMAL(18,2)  NULL DEFAULT 0,
    [Amount]       DECIMAL(18,2)  NULL DEFAULT 0,
    [Sales_Rate]   DECIMAL(18,2)  NULL DEFAULT 0
);
GO


-- =====================================================================
-- TABLE 4: Supplier
-- Used by: Add_Supplier.vb, Supplier.vb, Add_Purchase.vb
-- =====================================================================
CREATE TABLE [dbo].[Supplier] (
    [Sup_Id]            INT            IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [GST_No]            NVARCHAR(50)   NULL,
    [Supplier_Name]     NVARCHAR(200)  NOT NULL,
    [Brand]             NVARCHAR(200)  NULL,
    [Address]           NVARCHAR(500)  NULL,
    [State]             NVARCHAR(100)  NULL,
    [City]              NVARCHAR(100)  NULL,
    [Contact_no]        NVARCHAR(15)   NULL,
    [Payment_Duration]  NVARCHAR(50)   NULL,
    [Bank_Name]         NVARCHAR(200)  NULL
);
GO

-- Alias: Code also references "Supplier_ID" in DataGridView (.Item("Supplier_ID",...))
-- but INSERT/UPDATE/DELETE use "Sup_Id". The DataGridView reads from "select * from Supplier"
-- so the column name is "Sup_Id". The .Item("Supplier_ID",...) may need to match.
-- We'll keep "Sup_Id" as that's what DELETE uses: "delete from Supplier where Sup_Id=..."


-- =====================================================================
-- TABLE 5: Purchase_Summary
-- Used by: Add_Purchase.vb, Purchase.vb, Purchase_rpt.vb
-- =====================================================================
CREATE TABLE [dbo].[Purchase_Summary] (
    [Purchase_Sum_Id]  INT            IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Bill_Date]        DATE           NULL,
    [Due_Date]         DATE           NULL,
    [Invoice_No]       NVARCHAR(50)   NULL,
    [Ledger_Name]      NVARCHAR(200)  NULL,
    [Round_Off]        DECIMAL(18,2)  NULL DEFAULT 0,
    [Total_pgst]       DECIMAL(18,2)  NULL DEFAULT 0,
    [Total_Amount]     DECIMAL(18,2)  NULL DEFAULT 0
);
GO


-- =====================================================================
-- TABLE 6: Purchase_Detail
-- Used by: Add_Purchase.vb
-- =====================================================================
CREATE TABLE [dbo].[Purchase_Detail] (
    [Purchase_ID]   INT            IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Invoice_No]    NVARCHAR(50)   NULL,
    [Product_Name]  NVARCHAR(200)  NULL,
    [HSN_Code]      NVARCHAR(50)   NULL,
    [Quantity]      INT            NULL DEFAULT 0,
    [Rate]          DECIMAL(18,2)  NULL DEFAULT 0,
    [P_CGST]        DECIMAL(18,2)  NULL DEFAULT 0,
    [P_SGST]        DECIMAL(18,2)  NULL DEFAULT 0,
    [P_Total]       DECIMAL(18,2)  NULL DEFAULT 0
);
GO


-- =====================================================================
-- TABLE 7: Stock (Stock / Inventory Master)
-- Used by: Add_Purchase.vb, Stock.vb, Invoice.vb, Delete_IMEI.vb, Stock_report.vb
-- =====================================================================
CREATE TABLE [dbo].[Stock] (
    [Stock_id]      INT            IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Invoice_No]    NVARCHAR(50)   NULL,
    [Product_Name]  NVARCHAR(200)  NULL,
    [IMEI_NUMBER]   NVARCHAR(50)   NULL,
    [HSN_Code]      NVARCHAR(50)   NULL,
    [Quantity]      INT            NULL DEFAULT 0
);
GO


-- =====================================================================
-- TABLE 8: IMEI_NUM (Temporary IMEI Storage)
-- Used by: IMEI_store.vb, Add_Purchase.vb
-- =====================================================================
CREATE TABLE [dbo].[IMEI_NUM] (
    [IMEI_Id]       INT            IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [IMEI_NUMBER]   NVARCHAR(50)   NULL,
    [Purchase_id]   INT            NULL
);
GO


-- =====================================================================
-- TABLE 9: Sales_Summary
-- Used by: Invoice.vb
-- =====================================================================
CREATE TABLE [dbo].[Sales_Summary] (
    [Sales_Id]             INT            IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Invoice_No]           NVARCHAR(50)   NULL,
    [Bill_Date]            DATE           NULL,
    [Customer_Name]        NVARCHAR(200)  NULL,
    [Customer_Mobile_no]   NVARCHAR(15)   NULL,
    [Customer_address]     NVARCHAR(500)  NULL,
    [Discount]             DECIMAL(18,2)  NULL DEFAULT 0,
    [Round_Off]            DECIMAL(18,2)  NULL DEFAULT 0,
    [Total_gst]            DECIMAL(18,2)  NULL DEFAULT 0,
    [Total_Amount]         DECIMAL(18,2)  NULL DEFAULT 0,
    [Tax_amt]              DECIMAL(18,2)  NULL DEFAULT 0
);
GO


-- =====================================================================
-- TABLE 10: Sales_Detail
-- Used by: Invoice.vb
-- =====================================================================
CREATE TABLE [dbo].[Sales_Detail] (
    [Sales_Detail_Id]  INT            IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Invoice_No]       NVARCHAR(50)   NULL,
    [IMEI_No]          NVARCHAR(50)   NULL,
    [Product_Name]     NVARCHAR(200)  NULL,
    [Quantity]         INT            NULL DEFAULT 0,
    [Rate]             DECIMAL(18,2)  NULL DEFAULT 0,
    [CGST]             DECIMAL(18,2)  NULL DEFAULT 0,
    [SGST]             DECIMAL(18,2)  NULL DEFAULT 0,
    [Taxable_amt]      DECIMAL(18,2)  NULL DEFAULT 0
);
GO


-- =====================================================================
-- TABLE 11: configure_master (Invoice Number Configuration)
-- Used by: Invoice.vb
-- =====================================================================
CREATE TABLE [dbo].[configure_master] (
    [Invoice]  INT  NOT NULL DEFAULT 1
);
GO

-- Insert initial invoice counter starting at 1
INSERT INTO [dbo].[configure_master] ([Invoice])
VALUES (1);
GO


-- =====================================================================
-- PRINT SUCCESS MESSAGE
-- =====================================================================
PRINT '============================================================';
PRINT '  Mobile_Inventory_System Database Created Successfully!';
PRINT '============================================================';
PRINT '';
PRINT '  Tables Created:';
PRINT '    1.  Login              - User authentication';
PRINT '    2.  Customer           - Customer master';
PRINT '    3.  Product1           - Product master';
PRINT '    4.  Supplier           - Supplier master';
PRINT '    5.  Purchase_Summary   - Purchase bill summary';
PRINT '    6.  Purchase_Detail    - Purchase bill line items';
PRINT '    7.  Stock              - Current inventory/stock';
PRINT '    8.  IMEI_NUM           - Temporary IMEI number storage';
PRINT '    9.  Sales_Summary      - Sales invoice summary';
PRINT '    10. Sales_Detail       - Sales invoice line items';
PRINT '    11. configure_master   - Invoice number counter';
PRINT '';
PRINT '  Default Login Credentials:';
PRINT '    Username: admin';
PRINT '    Password: admin';
PRINT '';
PRINT '  NOTE: Update the connection string in Dao.vb to match';
PRINT '        your SQL Server instance name.';
PRINT '============================================================';
GO
