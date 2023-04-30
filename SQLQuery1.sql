Create database libraryManage
use libraryManage

CREATE TABLE [Books](
	[BookID] int NOT NULL,
	[BookName] [nvarchar](50) NOT NULL,
	[BookAuthor] [nvarchar](50) NOT NULL,
	[GenreID] [nvarchar](50) NOT NULL,
	[PublishID] [nvarchar](50) NOT NULL,
	[Quantity] [int] NOT NULL
)

CREATE TABLE [Employee](
	[EmployeeID] [nvarchar](50) NOT NULL,
	[EmployeeName] [nvarchar](50) NOT NULL,
	[EmployeeBirth] [nvarchar](50) NOT NULL,
	[EmployeeGender] [nchar](10) NOT NULL,
	[EmployeeAddress] [nvarchar](50) NOT NULL,
	[EmployeePhone] [nchar](10) NOT NULL,
	[EmployeeEmail] [nvarchar](50) NOT NULL,
	[EmployeePosition] [nvarchar](50) NOT NULL,
	[img] [nvarchar](max) NULL
)

CREATE TABLE [PublishCompany](
	[PublishID] [nvarchar](50) NOT NULL,
	[PublishName] [nvarchar](50) NOT NULL,
	[PublishAddress] [nvarchar](50) NOT NULL,
	[PublishPhone] [nchar](10) NOT NULL,
	[PublishEmail] [nvarchar](50) NOT NULL,
	)


CREATE TABLE [Reader](
	[ReaderID] [nvarchar](50) NOT NULL,
	[ReaderName] [nvarchar](50) NOT NULL,
	[ReaderGender] [nvarchar](20) NOT NULL,
	[ReaderAddress] [nvarchar](50) NOT NULL,
	[ReaderPhone] [nvarchar](50) NOT NULL,
	[ReaderEmail] [nvarchar](50) NOT NULL,
	[img] [nvarchar](max) NULL,
)

CREATE TABLE [Report](
	[ReportID] [nvarchar](50) NOT NULL,
	[ReaderID] [nvarchar](50) NULL,
	[EmployeeID] [nvarchar](50) NULL,
	[DayIssue] [nvarchar](50) NULL,
	[Expiration] [nvarchar](50) NULL,
	[DayReturn] [nvarchar](50) NULL
)

CREATE TABLE [ReportDetail](
	[ReportID] [nvarchar](50) NOT NULL,
	[BookID] [nvarchar](50) NOT NULL,
	[ReaderID] [nvarchar](50) NOT NULL,
	[Status] [nvarchar](50) NOT NULL
)

CREATE TABLE [Users](
	[id] [int] NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nchar](10) NOT NULL
)