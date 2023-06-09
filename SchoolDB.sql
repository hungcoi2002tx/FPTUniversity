USE [master]
GO
/****** Object:  Database [SchoolContextDB]    Script Date: 6/9/2023 11:17:38 AM ******/
CREATE DATABASE [SchoolContextDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolContextDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER2019\MSSQL\DATA\SchoolContextDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SchoolContextDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER2019\MSSQL\DATA\SchoolContextDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SchoolContextDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolContextDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SchoolContextDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SchoolContextDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SchoolContextDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SchoolContextDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SchoolContextDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SchoolContextDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SchoolContextDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SchoolContextDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolContextDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SchoolContextDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SchoolContextDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SchoolContextDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SchoolContextDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SchoolContextDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SchoolContextDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SchoolContextDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SchoolContextDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SchoolContextDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SchoolContextDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SchoolContextDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SchoolContextDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [SchoolContextDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SchoolContextDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SchoolContextDB] SET  MULTI_USER 
GO
ALTER DATABASE [SchoolContextDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SchoolContextDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SchoolContextDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SchoolContextDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SchoolContextDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SchoolContextDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SchoolContextDB] SET QUERY_STORE = OFF
GO
USE [SchoolContextDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/9/2023 11:17:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 6/9/2023 11:17:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseID] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Credits] [int] NOT NULL,
	[DepartmentID] [int] NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CourseInstructor]    Script Date: 6/9/2023 11:17:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseInstructor](
	[CoursesCourseID] [int] NOT NULL,
	[InstructorsID] [int] NOT NULL,
 CONSTRAINT [PK_CourseInstructor] PRIMARY KEY CLUSTERED 
(
	[CoursesCourseID] ASC,
	[InstructorsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 6/9/2023 11:17:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[DepartmentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Budget] [money] NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[InstructorID] [int] NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enrollments]    Script Date: 6/9/2023 11:17:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enrollments](
	[EnrollmentID] [int] IDENTITY(1,1) NOT NULL,
	[CourseID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[Grade] [int] NULL,
 CONSTRAINT [PK_Enrollments] PRIMARY KEY CLUSTERED 
(
	[EnrollmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Instructor]    Script Date: 6/9/2023 11:17:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[HireDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Instructor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OfficeAssignments]    Script Date: 6/9/2023 11:17:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OfficeAssignments](
	[InstructorID] [int] NOT NULL,
	[Location] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_OfficeAssignments] PRIMARY KEY CLUSTERED 
(
	[InstructorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 6/9/2023 11:17:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[EnrollmentDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230311153642_InitialCreate', N'6.0.7')
GO
INSERT [dbo].[Course] ([CourseID], [Title], [Credits], [DepartmentID]) VALUES (1045, N'Calculus', 4, 4)
INSERT [dbo].[Course] ([CourseID], [Title], [Credits], [DepartmentID]) VALUES (1050, N'Chemistry', 3, 3)
INSERT [dbo].[Course] ([CourseID], [Title], [Credits], [DepartmentID]) VALUES (2021, N'Composition', 3, 1)
INSERT [dbo].[Course] ([CourseID], [Title], [Credits], [DepartmentID]) VALUES (2042, N'Literature', 4, 1)
INSERT [dbo].[Course] ([CourseID], [Title], [Credits], [DepartmentID]) VALUES (3141, N'Trigonometry', 4, 2)
INSERT [dbo].[Course] ([CourseID], [Title], [Credits], [DepartmentID]) VALUES (4022, N'Microeconomics', 3, 4)
INSERT [dbo].[Course] ([CourseID], [Title], [Credits], [DepartmentID]) VALUES (4041, N'Macroeconomics', 3, 4)
GO
INSERT [dbo].[CourseInstructor] ([CoursesCourseID], [InstructorsID]) VALUES (2021, 1)
INSERT [dbo].[CourseInstructor] ([CoursesCourseID], [InstructorsID]) VALUES (2042, 1)
INSERT [dbo].[CourseInstructor] ([CoursesCourseID], [InstructorsID]) VALUES (1045, 2)
INSERT [dbo].[CourseInstructor] ([CoursesCourseID], [InstructorsID]) VALUES (1050, 3)
INSERT [dbo].[CourseInstructor] ([CoursesCourseID], [InstructorsID]) VALUES (3141, 3)
INSERT [dbo].[CourseInstructor] ([CoursesCourseID], [InstructorsID]) VALUES (1050, 4)
INSERT [dbo].[CourseInstructor] ([CoursesCourseID], [InstructorsID]) VALUES (4022, 5)
INSERT [dbo].[CourseInstructor] ([CoursesCourseID], [InstructorsID]) VALUES (4041, 5)
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([DepartmentID], [Name], [Budget], [StartDate], [InstructorID]) VALUES (1, N'English', 350000.0000, CAST(N'2007-09-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Departments] ([DepartmentID], [Name], [Budget], [StartDate], [InstructorID]) VALUES (2, N'Mathematics', 100000.0000, CAST(N'2007-09-01T00:00:00.0000000' AS DateTime2), 2)
INSERT [dbo].[Departments] ([DepartmentID], [Name], [Budget], [StartDate], [InstructorID]) VALUES (3, N'Engineering', 350000.0000, CAST(N'2007-09-01T00:00:00.0000000' AS DateTime2), 3)
INSERT [dbo].[Departments] ([DepartmentID], [Name], [Budget], [StartDate], [InstructorID]) VALUES (4, N'Economics', 100000.0000, CAST(N'2007-09-01T00:00:00.0000000' AS DateTime2), 4)
SET IDENTITY_INSERT [dbo].[Departments] OFF
GO
SET IDENTITY_INSERT [dbo].[Enrollments] ON 

INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (1, 1050, 1, 0)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (2, 4022, 1, 2)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (3, 4041, 1, 1)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (4, 1045, 2, 1)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (5, 3141, 2, 1)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (6, 2021, 2, 1)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (7, 1050, 3, NULL)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (8, 4022, 3, 1)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (9, 1050, 4, 1)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (10, 2021, 5, 1)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (11, 2042, 6, 1)
SET IDENTITY_INSERT [dbo].[Enrollments] OFF
GO
SET IDENTITY_INSERT [dbo].[Instructor] ON 

INSERT [dbo].[Instructor] ([ID], [LastName], [FirstName], [HireDate]) VALUES (1, N'Abercrombie', N'Kim', CAST(N'1995-03-11T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Instructor] ([ID], [LastName], [FirstName], [HireDate]) VALUES (2, N'Fakhouri', N'Fadi', CAST(N'2002-07-06T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Instructor] ([ID], [LastName], [FirstName], [HireDate]) VALUES (3, N'Harui', N'Roger', CAST(N'1998-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Instructor] ([ID], [LastName], [FirstName], [HireDate]) VALUES (4, N'Kapoor', N'Candace', CAST(N'2001-01-15T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Instructor] ([ID], [LastName], [FirstName], [HireDate]) VALUES (5, N'Zheng', N'Roger', CAST(N'2004-02-12T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Instructor] OFF
GO
INSERT [dbo].[OfficeAssignments] ([InstructorID], [Location]) VALUES (2, N'Smith 17')
INSERT [dbo].[OfficeAssignments] ([InstructorID], [Location]) VALUES (3, N'Gowan 27')
INSERT [dbo].[OfficeAssignments] ([InstructorID], [Location]) VALUES (4, N'Thompson 304')
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([ID], [LastName], [FirstName], [EnrollmentDate]) VALUES (1, N'Alexander', N'Carson', CAST(N'2016-09-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Student] ([ID], [LastName], [FirstName], [EnrollmentDate]) VALUES (2, N'Alonso', N'Meredith', CAST(N'2018-09-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Student] ([ID], [LastName], [FirstName], [EnrollmentDate]) VALUES (3, N'Anand', N'Arturo', CAST(N'2019-09-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Student] ([ID], [LastName], [FirstName], [EnrollmentDate]) VALUES (4, N'Barzdukas', N'Gytis', CAST(N'2018-09-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Student] ([ID], [LastName], [FirstName], [EnrollmentDate]) VALUES (5, N'Li', N'Yan', CAST(N'2018-09-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Student] ([ID], [LastName], [FirstName], [EnrollmentDate]) VALUES (6, N'Justice', N'Peggy', CAST(N'2017-09-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Student] ([ID], [LastName], [FirstName], [EnrollmentDate]) VALUES (7, N'Norman', N'Laura', CAST(N'2019-09-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Student] ([ID], [LastName], [FirstName], [EnrollmentDate]) VALUES (8, N'Olivetto', N'Nino', CAST(N'2011-09-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
/****** Object:  Index [IX_Course_DepartmentID]    Script Date: 6/9/2023 11:17:39 AM ******/
CREATE NONCLUSTERED INDEX [IX_Course_DepartmentID] ON [dbo].[Course]
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CourseInstructor_InstructorsID]    Script Date: 6/9/2023 11:17:39 AM ******/
CREATE NONCLUSTERED INDEX [IX_CourseInstructor_InstructorsID] ON [dbo].[CourseInstructor]
(
	[InstructorsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Departments_InstructorID]    Script Date: 6/9/2023 11:17:39 AM ******/
CREATE NONCLUSTERED INDEX [IX_Departments_InstructorID] ON [dbo].[Departments]
(
	[InstructorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Enrollments_CourseID]    Script Date: 6/9/2023 11:17:39 AM ******/
CREATE NONCLUSTERED INDEX [IX_Enrollments_CourseID] ON [dbo].[Enrollments]
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Enrollments_StudentID]    Script Date: 6/9/2023 11:17:39 AM ******/
CREATE NONCLUSTERED INDEX [IX_Enrollments_StudentID] ON [dbo].[Enrollments]
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_Departments_DepartmentID] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Departments] ([DepartmentID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_Departments_DepartmentID]
GO
ALTER TABLE [dbo].[CourseInstructor]  WITH CHECK ADD  CONSTRAINT [FK_CourseInstructor_Course_CoursesCourseID] FOREIGN KEY([CoursesCourseID])
REFERENCES [dbo].[Course] ([CourseID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CourseInstructor] CHECK CONSTRAINT [FK_CourseInstructor_Course_CoursesCourseID]
GO
ALTER TABLE [dbo].[CourseInstructor]  WITH CHECK ADD  CONSTRAINT [FK_CourseInstructor_Instructor_InstructorsID] FOREIGN KEY([InstructorsID])
REFERENCES [dbo].[Instructor] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CourseInstructor] CHECK CONSTRAINT [FK_CourseInstructor_Instructor_InstructorsID]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Instructor_InstructorID] FOREIGN KEY([InstructorID])
REFERENCES [dbo].[Instructor] ([ID])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Instructor_InstructorID]
GO
ALTER TABLE [dbo].[Enrollments]  WITH CHECK ADD  CONSTRAINT [FK_Enrollments_Course_CourseID] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Enrollments] CHECK CONSTRAINT [FK_Enrollments_Course_CourseID]
GO
ALTER TABLE [dbo].[Enrollments]  WITH CHECK ADD  CONSTRAINT [FK_Enrollments_Student_StudentID] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Enrollments] CHECK CONSTRAINT [FK_Enrollments_Student_StudentID]
GO
ALTER TABLE [dbo].[OfficeAssignments]  WITH CHECK ADD  CONSTRAINT [FK_OfficeAssignments_Instructor_InstructorID] FOREIGN KEY([InstructorID])
REFERENCES [dbo].[Instructor] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OfficeAssignments] CHECK CONSTRAINT [FK_OfficeAssignments_Instructor_InstructorID]
GO
USE [master]
GO
ALTER DATABASE [SchoolContextDB] SET  READ_WRITE 
GO
