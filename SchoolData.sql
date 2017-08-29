-- =============================================
-- Author:	Tim Francis
-- Create date: March, 2017
-- Description:	SchoolData Database Script
-- Project:	Final Project - CPRG 254 ADO.NET
-- =============================================

/********************************************************************
	PART ONE - CREATE DATABASE
********************************************************************/


use Master
go

IF EXISTS (SELECT * FROM sysdatabases WHERE name = 'SchoolData')
BEGIN
  DROP Database SchoolData
END
go

CREATE DATABASE SchoolData
go

Use SchoolData
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Department Lookup Table:

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Department]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Department](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](10) NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

--Province Lookup Table:

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Province]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Province](
        [Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [char](2) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Province] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

--Course Table

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Course]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Course](
        [Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [char](7) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [text] NOT NULL,
	[Fee] [decimal](18, 2) NOT NULL,
	[DepartmentId] [int] NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO

--Student Table:

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Student]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(615243,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[ProvinceId] [int] NOT NULL,
	[PostalCode] [varchar](7) NOT NULL,
	[Phone] [varchar](12) NULL,
	[Email] [varchar](50) NULL,
	[DepartmentId] [int] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

--Class Roster Table (Student enrols in course section)

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClassRoster]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ClassRoster](
    [Id] [int] IDENTITY(1,1) NOT NULL,
	[CourseSectionId] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
	[DateRegistered] [datetime] NOT NULL,
 CONSTRAINT [PK_ClassRoster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

-- Course Section table (Every course may have multiple instances/sections):

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CourseSection]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CourseSection](
        [Id] [int] IDENTITY(1,1) NOT NULL,
	[CourseId] [int] NOT NULL,
	[SectionCode] [char](1) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[RoomNumber] [varchar](10) NULL,
 CONSTRAINT [PK_CourseSection] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

--Foreign Key Relationships:

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Course_Department]') AND parent_object_id = OBJECT_ID(N'[dbo].[Course]'))
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_Department] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_Department]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_Department]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student]'))
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Department] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Department]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_Province]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student]'))
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Province] FOREIGN KEY([ProvinceId])
REFERENCES [dbo].[Province] ([Id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Province]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ClassRoster_CourseSection]') AND parent_object_id = OBJECT_ID(N'[dbo].[ClassRoster]'))
ALTER TABLE [dbo].[ClassRoster]  WITH CHECK ADD  CONSTRAINT [FK_ClassRoster_CourseSection] FOREIGN KEY([CourseSectionId])
REFERENCES [dbo].[CourseSection] ([Id])
GO
ALTER TABLE [dbo].[ClassRoster] CHECK CONSTRAINT [FK_ClassRoster_CourseSection]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ClassRoster_Student]') AND parent_object_id = OBJECT_ID(N'[dbo].[ClassRoster]'))
ALTER TABLE [dbo].[ClassRoster]  WITH CHECK ADD  CONSTRAINT [FK_ClassRoster_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[ClassRoster] CHECK CONSTRAINT [FK_ClassRoster_Student]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CourseSection_Course]') AND parent_object_id = OBJECT_ID(N'[dbo].[CourseSection]'))
ALTER TABLE [dbo].[CourseSection]  WITH CHECK ADD  CONSTRAINT [FK_CourseSection_Course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([Id])
GO
ALTER TABLE [dbo].[CourseSection] CHECK CONSTRAINT [FK_CourseSection_Course]



/********************************************************************
	PART TWO - INSERT SEED DATA
********************************************************************/

--  INSERT DEPARTMENT DATA

SET IDENTITY_INSERT [Department] ON
INSERT INTO Department(Id, Code, Name) VALUES(1, 'IT','Information Technologies')
INSERT INTO Department(Id, Code, Name) VALUES(2, 'BUS','Business Management')
INSERT INTO Department(Id, Code, Name) VALUES(3, 'TRANS','Transportation')
INSERT INTO Department(Id, Code, Name) VALUES(4, 'CONST','Construction Technologies')
INSERT INTO Department(Id, Code, Name) VALUES(5, 'TOUR','Tourism')
SET IDENTITY_INSERT [Department] OFF
GO

--  INSERT PROVINCE DATA

SET IDENTITY_INSERT [Province] ON
INSERT INTO Province(Id, Code, Name) VALUES(1, 'BC','British Columbia')
INSERT INTO Province(Id, Code, Name) VALUES(2, 'AB','Alberta')
INSERT INTO Province(Id, Code, Name) VALUES(3, 'SK','Saskatchewan')
INSERT INTO Province(Id, Code, Name) VALUES(4, 'MB','Manitoba')
INSERT INTO Province(Id, Code, Name) VALUES(5, 'ON','Ontario')
INSERT INTO Province(Id, Code, Name) VALUES(6, 'QC','Quebec')
INSERT INTO Province(Id, Code, Name) VALUES(7, 'NB','New Brunswick')
INSERT INTO Province(Id, Code, Name) VALUES(8, 'NS','Nova Scotia')
INSERT INTO Province(Id, Code, Name) VALUES(9, 'PE','Prince Edward Island')
INSERT INTO Province(Id, Code, Name) VALUES(10, 'NL','Newfoundland and Labrador')
INSERT INTO Province(Id, Code, Name) VALUES(11, 'YT','Yukon')
INSERT INTO Province(Id, Code, Name) VALUES(12, 'NT','Northwest Territories')
INSERT INTO Province(Id, Code, Name) VALUES(13, 'NU','Nunavut')
SET IDENTITY_INSERT [Province] OFF
GO

--  INSERT STUDENT DATA

SET IDENTITY_INSERT [Student] ON
INSERT INTO Student(Id, FirstName, LastName, Address, City, ProvinceId, PostalCode, Phone, Email, DepartmentId) 
VALUES(601001, 'John', 'Doe', '123 45th Ave NW', 'Calgary', 2, 'T2T 2T2', '403-222-2323', 'jdoe@calgary.com', 1)

INSERT INTO Student(Id, FirstName, LastName, Address, City, ProvinceId, PostalCode, Phone, Email, DepartmentId) 
VALUES(601002, 'Jane', 'Smith', '3425 29th St NW', 'Calgary', 2, 'T3T 3T3', '403-333-3434', 'jsmith@smith.com', 2)

INSERT INTO Student(Id, FirstName, LastName, Address, City, ProvinceId, PostalCode, Phone, Email, DepartmentId) 
VALUES(601003, 'Benji', 'Nataway', '435 - 1212 66th Ave NW', 'Calgary', 2, 'T4T 4T4', '403-444-4545', 'benji@yahoo.com', 1)

INSERT INTO Student(Id, FirstName, LastName, Address, City, ProvinceId, PostalCode, Phone, Email, DepartmentId) 
VALUES(601004, 'Cam', 'Newton', 'Box 1212', 'Prince Albert', 3, 'S6S 6S6', '306-555-5656', 'camnewton@pa.com', 3)

INSERT INTO Student(Id, FirstName, LastName, Address, City, ProvinceId, PostalCode, Phone, Email, DepartmentId) 
VALUES(601005, 'Kim', 'Quan', '123 Millar Ave', 'Saskatoon', 3, 'S6V 3V3', '306-650-8900', 'kimmy@hotmail.com', 4)

INSERT INTO Student(Id, FirstName, LastName, Address, City, ProvinceId, PostalCode, Phone, Email, DepartmentId) 
VALUES(601006, 'Bill', 'Carr', '34 West Nile', 'Vancouver', 1, 'V1A 1A2', '250-852-3256', 'bcarr@bc.com', 3)
SET IDENTITY_INSERT [Student] OFF
GO

-- INSERT COURSE DATA

SET IDENTITY_INSERT [Course] ON
INSERT INTO Course(Id, Code, Name, Description, Fee, DepartmentId) 
VALUES(1,'COMP222', 'Introduction to VB.NET', 'An introductory course to the new Visual Basic environment in .NET', 755.00, 1)

INSERT INTO Course(Id, Code, Name, Description, Fee, DepartmentId) 
VALUES(2,'COMP235', 'Advanced VB.NET', 'A more advanced course in the new Visual Basic environment in .NET', 825.00, 1)

INSERT INTO Course(Id, Code, Name, Description, Fee, DepartmentId) 
VALUES(3,'MGMT200', 'Human Resources Today', 'An introductory course in human resources management', 650.00, 2)

INSERT INTO Course(Id, Code, Name, Description, Fee, DepartmentId) 
VALUES(4,'MGMT250', 'Financial Management', 'An intermediate course in financial management for the enterprise', 700.00, 2)
SET IDENTITY_INSERT [Course] OFF
GO

-- INSERT COURSE SECTION
SET IDENTITY_INSERT [CourseSection] ON
INSERT INTO CourseSection(Id, SectionCode, CourseId, RoomNumber, StartDate, EndDate)
VALUES (1, 'A', 1, 'J120', '2017-JAN-04', '2017-FEB-27')

INSERT INTO CourseSection(Id, SectionCode, CourseId, RoomNumber, StartDate, EndDate)
VALUES (2, 'B', 1, 'H222', '2017-JAN-05', '2017-FEB-28')

INSERT INTO CourseSection(Id, SectionCode, CourseId, RoomNumber, StartDate, EndDate)
VALUES (3, 'A', 2, 'M321', '2017-JAN-04', '2017-FEB-12')
SET IDENTITY_INSERT [CourseSection] OFF
GO

-- INSERT CLASS ROSTER (stuidents enrol into a course section on a specific date)
INSERT INTO ClassRoster (CourseSectionId, StudentId, DateRegistered) 
VALUES (1, 601001, '2016-DEC-15')

INSERT INTO ClassRoster (CourseSectionId, StudentId, DateRegistered) 
VALUES (1, 601003, '2016-DEC-16')

INSERT INTO ClassRoster (CourseSectionId, StudentId, DateRegistered) 
VALUES (2, 601001, '2016-DEC-16')

INSERT INTO ClassRoster (CourseSectionId, StudentId, DateRegistered) 
VALUES (3, 601003, '2016-DEC-20')

INSERT INTO ClassRoster (CourseSectionId, StudentId, DateRegistered) 
VALUES (3, 601002, '2016-DEC-21')
GO

-- TEST QUERY (Get list of courses that a student is enrolled in- display Course Name, Section Code, Start Date, Department of Course)
SELECT crs.Name, section.SectionCode, section.StartDate, dept.Code  
FROM   Student std JOIN ClassRoster roster ON std.Id = roster.StudentId INNER JOIN 
       CourseSection section ON roster.CourseSectionId = section.Id INNER JOIN 
       Course crs ON section.CourseId = crs.Id INNER JOIN 
       Department dept ON crs.DepartmentId = dept.Id 
WHERE  std.Id = 601001    
 GO