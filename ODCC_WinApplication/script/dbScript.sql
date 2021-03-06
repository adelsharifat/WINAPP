USE [master]
GO
/****** Object:  Database [CMIS]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE DATABASE [CMIS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TicketDB', FILENAME = N'E:\7- Database - INT\Sharifat\CMIS.mdf' , SIZE = 139264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB ), 
 FILEGROUP [GatePassDocumentStore] CONTAINS FILESTREAM 
( NAME = N'GatePass_FileStream', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL13.CMIS_INT\MSSQL\DATA\GatePass_FileStream' , MAXSIZE = UNLIMITED), 
 FILEGROUP [JRDocumentStore] CONTAINS FILESTREAM  DEFAULT
( NAME = N'JRDB_FileStream', FILENAME = N'E:\7- Database - INT\Sharifat\JRDB_FileStream' , MAXSIZE = UNLIMITED), 
 FILEGROUP [NotifyDocumentStore] CONTAINS FILESTREAM 
( NAME = N'NotifyDB_FileStream', FILENAME = N'E:\7- Database - INT\Sharifat\NotifyDB_FileStream' , MAXSIZE = UNLIMITED), 
 FILEGROUP [QCElectricalDocumentStore] CONTAINS FILESTREAM 
( NAME = N'QCElectrical_FileStream', FILENAME = N'E:\7- Database - INT\Sharifat\QCElectrical_FileStream' , MAXSIZE = UNLIMITED), 
 FILEGROUP [TKDocumentStore] CONTAINS FILESTREAM 
( NAME = N'TicketDB_FileStram', FILENAME = N'E:\7- Database - INT\Sharifat\TicketDB_FileStram' , MAXSIZE = UNLIMITED)
 LOG ON 
( NAME = N'TicketDB_log', FILENAME = N'E:\7- Database - INT\Sharifat\CMIS_log.ldf' , SIZE = 5383296KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CMIS] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CMIS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CMIS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CMIS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CMIS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CMIS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CMIS] SET ARITHABORT OFF 
GO
ALTER DATABASE [CMIS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CMIS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CMIS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CMIS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CMIS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CMIS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CMIS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CMIS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CMIS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CMIS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CMIS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CMIS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CMIS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CMIS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CMIS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CMIS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CMIS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CMIS] SET RECOVERY FULL 
GO
ALTER DATABASE [CMIS] SET  MULTI_USER 
GO
ALTER DATABASE [CMIS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CMIS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CMIS] SET FILESTREAM( NON_TRANSACTED_ACCESS = FULL, DIRECTORY_NAME = N'TicketDB' ) 
GO
ALTER DATABASE [CMIS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CMIS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CMIS', N'ON'
GO
ALTER DATABASE [CMIS] SET QUERY_STORE = OFF
GO
USE [CMIS]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [CMIS]
GO
/****** Object:  User [Sharifat]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE USER [Sharifat] FOR LOGIN [Sharifat] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [Sharifat]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Sharifat]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Sharifat]
GO
/****** Object:  Schema [ACL]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE SCHEMA [ACL]
GO
/****** Object:  Schema [CM]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE SCHEMA [CM]
GO
/****** Object:  Schema [EL]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE SCHEMA [EL]
GO
/****** Object:  Schema [Electrical]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE SCHEMA [Electrical]
GO
/****** Object:  Schema [GatePass]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE SCHEMA [GatePass]
GO
/****** Object:  Schema [JobReport]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE SCHEMA [JobReport]
GO
/****** Object:  Schema [JR]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE SCHEMA [JR]
GO
/****** Object:  Schema [Notify]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE SCHEMA [Notify]
GO
/****** Object:  Schema [QCEL]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE SCHEMA [QCEL]
GO
/****** Object:  Schema [QCElectrical]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE SCHEMA [QCElectrical]
GO
/****** Object:  Schema [SecAcl]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE SCHEMA [SecAcl]
GO
/****** Object:  Schema [SGN]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE SCHEMA [SGN]
GO
/****** Object:  Schema [TC]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE SCHEMA [TC]
GO
/****** Object:  Schema [TICKET]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE SCHEMA [TICKET]
GO
/****** Object:  UserDefinedTableType [CM].[FileItemType]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE TYPE [CM].[FileItemType] AS TABLE(
	[Id] [int] NULL,
	[FileName] [nvarchar](255) NOT NULL,
	[Remark] [nvarchar](255) NULL,
	[CustomType] [nvarchar](50) NULL,
	[FileType] [varchar](50) NULL,
	[Content] [varbinary](max) NULL
)
GO
/****** Object:  UserDefinedTableType [CM].[IdsTable]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE TYPE [CM].[IdsTable] AS TABLE(
	[Id] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [CM].[TVPAttachment]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE TYPE [CM].[TVPAttachment] AS TABLE(
	[Id] [int] NULL,
	[stream_id] [uniqueidentifier] NULL,
	[FileStream] [varbinary](max) NULL,
	[FileName] [varchar](100) NULL,
	[Remark] [nvarchar](500) NULL,
	[Type] [varchar](100) NULL,
	[CustomType] [varchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [EL].[TvpPackingItem]    Script Date: 2/9/2022 5:49:39 PM ******/
CREATE TYPE [EL].[TvpPackingItem] AS TABLE(
	[Id] [int] NOT NULL,
	[ItemCodeId] [int] NOT NULL,
	[ItemCode] [varchar](150) NOT NULL,
	[UnitId] [int] NOT NULL,
	[VendorId] [int] NOT NULL,
	[TagNo] [varchar](100) NULL,
	[CategoryId] [int] NOT NULL,
	[SubCategoryId] [int] NULL,
	[Description] [nvarchar](500) NULL,
	[Size] [varchar](50) NOT NULL,
	[PackingNo] [varchar](200) NOT NULL,
	[PLQty] [decimal](18, 2) NOT NULL,
	[QtyUnitId] [int] NOT NULL
)
GO
/****** Object:  UserDefinedTableType [EL].[TvpPackingItems]    Script Date: 2/9/2022 5:49:40 PM ******/
CREATE TYPE [EL].[TvpPackingItems] AS TABLE(
	[Id] [int] NOT NULL,
	[ItemCodeId] [int] NOT NULL,
	[ItemCode] [varchar](150) NOT NULL,
	[UnitId] [int] NOT NULL,
	[VendorId] [int] NOT NULL,
	[TagNo] [varchar](100) NULL,
	[CategoryId] [int] NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Size] [varchar](50) NOT NULL,
	[PackingNo] [varchar](200) NOT NULL,
	[PLQty] [decimal](18, 2) NOT NULL,
	[QtyUnitId] [int] NOT NULL
)
GO
/****** Object:  UserDefinedTableType [GatePass].[GatePassItems]    Script Date: 2/9/2022 5:49:40 PM ******/
CREATE TYPE [GatePass].[GatePassItems] AS TABLE(
	[Id] [int] NULL,
	[PersonContractId] [int] NULL,
	[NationalCode] [char](10) NULL,
	[CounterId] [int] NULL,
	[ContractId] [int] NULL,
	[EmployerId] [int] NULL,
	[ContractorId] [int] NULL,
	[RequestTypeId] [int] NULL,
	[UnitRequestId] [int] NULL,
	[Unit] [nvarchar](100) NULL,
	[AttendanceDate] [datetime] NULL,
	[AttendanceDuration] [int] NULL,
	[GatePassTypeId] [int] NULL,
	[JobPositionId] [int] NULL,
	[JobPosition] [nvarchar](100) NULL,
	[Remark] [nvarchar](400) NULL
)
GO
/****** Object:  UserDefinedTableType [GatePass].[ItemDetailType]    Script Date: 2/9/2022 5:49:40 PM ******/
CREATE TYPE [GatePass].[ItemDetailType] AS TABLE(
	[ObjectId] [int] NULL,
	[GatePassId] [int] NULL,
	[Accept] [bit] NULL
)
GO
/****** Object:  UserDefinedTableType [GatePass].[Items]    Script Date: 2/9/2022 5:49:40 PM ******/
CREATE TYPE [GatePass].[Items] AS TABLE(
	[Id] [int] NULL,
	[PersonContractId] [int] NULL,
	[CounterId] [int] NULL,
	[ContractId] [int] NULL,
	[EmployerId] [int] NULL,
	[ContractorId] [int] NULL,
	[RequestTypeId] [int] NULL,
	[UnitRequestId] [int] NULL,
	[Unit] [nvarchar](100) NULL,
	[AttendanceDate] [datetime] NULL,
	[AttendanceDuration] [int] NULL,
	[GatePassTypeId] [int] NULL,
	[JobPositionId] [int] NULL,
	[JobPosition] [nvarchar](100) NULL,
	[Remark] [nvarchar](400) NULL
)
GO
/****** Object:  UserDefinedTableType [GatePass].[ItemsType]    Script Date: 2/9/2022 5:49:40 PM ******/
CREATE TYPE [GatePass].[ItemsType] AS TABLE(
	[Id] [int] NULL,
	[PersonContractId] [int] NULL,
	[ContractId] [int] NULL,
	[EmployerId] [int] NULL,
	[ContractorId] [int] NULL,
	[RequestTypeId] [int] NULL,
	[UnitRequestId] [int] NULL,
	[Unit] [nvarchar](100) NULL,
	[AttendanceDate] [datetime] NULL,
	[AttendanceDuration] [int] NULL,
	[GatePassTypeId] [int] NULL,
	[JobPositionId] [int] NULL,
	[JobPosition] [nvarchar](100) NULL,
	[Remark] [nvarchar](400) NULL
)
GO
/****** Object:  UserDefinedTableType [GatePass].[SettingsItemsType]    Script Date: 2/9/2022 5:49:40 PM ******/
CREATE TYPE [GatePass].[SettingsItemsType] AS TABLE(
	[Id] [int] NULL,
	[Company] [int] NULL,
	[Name] [varchar](55) NULL,
	[Value] [varchar](55) NULL
)
GO
/****** Object:  UserDefinedTableType [JobReport].[FileItemType]    Script Date: 2/9/2022 5:49:40 PM ******/
CREATE TYPE [JobReport].[FileItemType] AS TABLE(
	[Id] [int] NULL,
	[FileName] [nvarchar](255) NOT NULL,
	[Remark] [nvarchar](255) NULL,
	[CustomType] [nvarchar](50) NULL,
	[FileType] [varchar](50) NULL,
	[Content] [varbinary](max) NULL
)
GO
/****** Object:  UserDefinedTableType [QCEL].[TVPCFItemsResult]    Script Date: 2/9/2022 5:49:40 PM ******/
CREATE TYPE [QCEL].[TVPCFItemsResult] AS TABLE(
	[Id] [int] NULL,
	[ItemId] [int] NULL,
	[RoleOrder] [int] NULL,
	[ItemValue] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [SecAcl].[ACLTableType]    Script Date: 2/9/2022 5:49:40 PM ******/
CREATE TYPE [SecAcl].[ACLTableType] AS TABLE(
	[Id] [int] NULL,
	[Name] [varchar](100) NOT NULL,
	[Allow] [bit] NULL,
	[Value] [varchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [TICKET].[FileItemType]    Script Date: 2/9/2022 5:49:40 PM ******/
CREATE TYPE [TICKET].[FileItemType] AS TABLE(
	[Id] [int] NULL,
	[FileName] [nvarchar](255) NOT NULL,
	[Remark] [nvarchar](255) NULL,
	[CustomType] [varchar](50) NULL,
	[FileType] [varchar](50) NULL,
	[Content] [varbinary](max) NULL
)
GO
/****** Object:  UserDefinedTableType [TICKET].[TicketIdsTable]    Script Date: 2/9/2022 5:49:40 PM ******/
CREATE TYPE [TICKET].[TicketIdsTable] AS TABLE(
	[Id] [int] NULL
)
GO
/****** Object:  UserDefinedFunction [CM].[AlterName]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [CM].[AlterName]
(
@ProjectId int,
@ObjectName VARCHAR(55),
@Name VARCHar(55),
@Language varchar(10)
)
RETURNS varchar(100)
AS
BEGIN
	DECLARE @Message varchar(100)
	Select @Message = [Message] From CM.Messages WHERE [Name] = @Name AND Lang = @Language And Type = @ObjectName And ProjectId = @ProjectId

	IF @Message IS NULL
		SET @Message = @Name

	RETURN @Message
END

GO
/****** Object:  UserDefinedFunction [CM].[FnGetConfigValue]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [CM].[FnGetConfigValue]
(	
	@ProjectId INT = 1,
	@Scope VARCHAR(50),
	@Name VARCHAR(50)
)
RETURNS NVARCHAR(MAX)
AS
BEGIN
	DECLARE @Value NVARCHAR(MAX)
	SELECT TOP(1)  @Value = Value FROM CM.CMConfig
	WHERE ProjectId = @ProjectId AND Scope = @Scope AND Name = @Name

	-- Return the result of the function
	RETURN @Value	
END
GO
/****** Object:  UserDefinedFunction [CM].[FnGetDocumentStatusText]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [CM].[FnGetDocumentStatusText]
(
@Posted bit,
@Complete bit,
@Accepted bit
)
RETURNS varchar(100)
AS
BEGIN
	DECLARE @Status varchar(55);
	
	Set @Status =
	CASE
		WHEN @Complete = 0 AND @Posted = 0 THEN N'SaveMode' 
		WHEN @Complete = 1 AND @Accepted = 1  THEN N'Accepted'
		WHEN @Complete = 0 AND @Posted = 1 THEN N'InProgress'
		WHEN @Complete = 1 AND @Accepted = 0 THEN N'Rejected'	
	END

	RETURN @Status
END

GO
/****** Object:  UserDefinedFunction [CM].[FNGetReportNoUniqueValue]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [CM].[FNGetReportNoUniqueValue]
(
	@ReportFormatValue varchar(150)
)
RETURNS varchar(150)
AS
BEGIN

	DECLARE @UniqueValues VARCHAR(151) 
	;WITH cteFind AS (
		SELECT
				LEFT(value, CHARINDEX(']', value)-1) As Name
			FROM
				STRING_SPLIT(@ReportFormatValue, '[')
			WHERE
				value LIKE '%]%'	
	)	
	SELECT @UniqueValues = COALESCE(@UniqueValues + '-', '') + Name 
	FROM cteFind

	return @UniqueValues

END

GO
/****** Object:  UserDefinedFunction [CM].[FnProjectName]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [CM].[FnProjectName]
(
	@ProjectId int
)
RETURNS nvarchar(50)
AS
BEGIN
	DECLARE @ProjectName nvarchar(50)

	SELECT @ProjectName = CONCAT([Name],'-',[Code]) FROM CM.Project WHERE Id = @ProjectId
	RETURN @ProjectName

END

GO
/****** Object:  UserDefinedFunction [SGN].[FnCanSkipSignRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnCanSkipSignRole]
(
	@ProjectId as int,
	@CompanyId as int,
	@ObjectName as varchar(55),
	@Role as varchar(55),
	@NextRole as varchar(55),
	@SendBack as bit  = 0
)
RETURNS varchar(55)
AS
BEGIN

	Declare @roleOrder as int;
	Declare @nextRoleOrder as int;
	Declare @Required as int = 0;
	Declare @ResultRole varchar(55);

	Declare @SignatureCycleTable as Table(Id int,ProjectId int,ObjectName varchar(55),[Role] varchar(55),[Order] int,RejectOrder int ,CompanyId int, [Required] bit,[BackRequired] bit );

	Insert Into @SignatureCycleTable
		SELECT * FROM CM.CMSignConfig
			Where ProjectId = @ProjectId and (CompanyId IS NULL or [CompanyId] = @CompanyId) and ObjectName = @objectName

	IF @SendBack = 0
		Begin
			Select @roleOrder = [Order] From @SignatureCycleTable where [Role] = @role
			Select @nextRoleOrder = [Order] From @SignatureCycleTable where [Role] = @nextRole

			Select @ResultRole = [Role],@Required = [Required] From @SignatureCycleTable
				where [Order] > @roleOrder and [Order] < @nextRoleOrder and [Required] = 1

			IF @Required IS NOT NULL AND @Required = 1
				RETURN @ResultRole -- Can Not Skip
			ELSE
				RETURN NULL -- Can Skip
		End
	IF @SendBack = 1
		Begin
			Select @roleOrder = [Order] From @SignatureCycleTable where [Role] = @role
			Select @nextRoleOrder = [Order] From @SignatureCycleTable where [Role] = @nextRole

			Select @ResultRole = [Role],@Required = [BackRequired] From @SignatureCycleTable
				where [Order] < @roleOrder and [Order] > @nextRoleOrder and [BackRequired] = 1

			IF @Required IS NOT NULL AND @Required = 1
				RETURN @ResultRole -- Can Not Skip
			ELSE
				RETURN NULL -- Can Skip
		End	
	RETURN 0
END


GO
/****** Object:  UserDefinedFunction [SGN].[FnCheckBackModeRoleHasBetweenSenderAndRevierRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create FUNCTION [SGN].[FnCheckBackModeRoleHasBetweenSenderAndRevierRole]
(
	@ProjectId int,
	@CompanyId int,
	@ObjectName varchar(55),
	@SenderRole varchar(55),
	@RecieverRole varchar(55)
)
RETURNS int
AS
BEGIN

	Declare @Result int = 0;
	DECLARE @SenderRoleOrder int
	DECLARE @ReciverRoleOrder int
	SELECT @SenderRoleOrder = SGN.FnGetSignRoleOrder(@ProjectId,@CompanyId,@ObjectName,@SenderRole)
	SELECT @ReciverRoleOrder = SGN.FnGetSignRoleOrder(@ProjectId,@CompanyId,@ObjectName,@RecieverRole)
	SELECT @Result = Count([Role]) FROM SGN.TVFGetBackSignSteps(@ProjectId,@CompanyId,@ObjectName)
		WHERE [PostModeOrder] < @SenderRoleOrder AND [PostModeOrder] > @ReciverRoleOrder

	Return @Result

END
GO
/****** Object:  UserDefinedFunction [SGN].[FnCheckRoleHasBetweenSenderAndRevierRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [SGN].[FnCheckRoleHasBetweenSenderAndRevierRole]
(
	@ProjectId int,
	@CompanyId int,
	@ObjectName varchar(55),
	@SenderRole varchar(55),
	@RecieverRole varchar(55)
)
RETURNS int
AS
BEGIN

	Declare @Result int = 0;
	DECLARE @SenderRoleOrder int
	DECLARE @ReciverRoleOrder int
	SELECT @SenderRoleOrder = SGN.FnGetSignRoleOrder(@ProjectId,@CompanyId,@ObjectName,@SenderRole)
	SELECT @ReciverRoleOrder = SGN.FnGetSignRoleOrder(@ProjectId,@CompanyId,@ObjectName,@RecieverRole)
	SELECT @Result = Count([Role]) FROM SGN.TVFGetPostSignSteps(@ProjectId,@CompanyId,@ObjectName)
		WHERE [PostModeOrder] > @SenderRoleOrder AND [PostModeOrder] < @ReciverRoleOrder

	Return @Result

END
GO
/****** Object:  UserDefinedFunction [SGN].[FnCheckRoleSigned]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnCheckRoleSigned]
(
	@ProjectId int,
	@CompanyId int,
	@ObjectName varchar(55),
	@ObjectId int,
	@DocumentNextRole varchar(55)

)
RETURNS int
AS
BEGIN
	Declare @Accecpted int
	Declare @TempTable Table (RowNumber int,[Role] varchar(55),[NextRole] varchar(55),Accepted int,[Order] int,[CreateDate] DateTime)
	Declare @IsFirstRole bit;
	
	Insert Into @TempTable
		Select Top 1  ROW_NUMBER() Over(
			Partition By s.ObjectName
			Order By [Order] , [CreateDate] desc 
			) RowNumber, s.[Role],s.[NextRole],s.[Accepted],s.[Order],s.CreateDate
			From CM.[CMSign] s
				Where  s.ObjectId = @ObjectId AND s.[Role] = @DocumentNextRole


	Select @Accecpted = [Accepted] FROM @TempTable

	IF @Accecpted = 0 OR @Accecpted IS NULL
		RETURN 0
	ELSE
		RETURN 1
		
	RETURN 0

END

GO
/****** Object:  UserDefinedFunction [SGN].[FnFirstNextSignRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnFirstNextSignRole]
(
	@ProjectId int,
	@CompanyId int,
	@ObjectName varchar(55)
)
RETURNS varchar(55)
AS
BEGIN
	
	DECLARE @FirstNextSignRole varchar(55)

	SELECT @FirstNextSignRole = [NextRole] FROM SGN.TVFGetPostSignSteps(@ProjectId,@CompanyId,@ObjectName) WHERE RowNUmber = 1 

	RETURN @FirstNextSignRole

END

GO
/****** Object:  UserDefinedFunction [SGN].[FnFirstSignRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnFirstSignRole]
(
	@ProjectId int,
	@CompanyId int,
	@ObjectName varchar(55)
)
RETURNS varchar(55)
AS
BEGIN
	
	DECLARE @FirstSignRole varchar(55)
	SELECT @FirstSignRole = [Role] FROM SGN.TVFGetPostSignSteps(@ProjectId,@CompanyId,@ObjectName) WHERE RowNUmber = 1 

	RETURN @FirstSignRole

END

GO
/****** Object:  UserDefinedFunction [SGN].[FnGetDocumentNextSignRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnGetDocumentNextSignRole]
(
	@ObjectId int
)
RETURNS varchar(55)
AS
BEGIN
	DECLARE @DocumentNextSignRole varchar(55)
	SELECT @DocumentNextSignRole = [DocumentOwnersRole] FROM CM.CMDocument WHERE Id = @ObjectId
	RETURN @DocumentNextSignRole
END

GO
/****** Object:  UserDefinedFunction [SGN].[FnGetPostSignRoleOrder]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create FUNCTION [SGN].[FnGetPostSignRoleOrder]
(
	@ProjectId int,
	@CompanyId int,
	@ObjectName varchar(55),
	@Role varchar(55)
)
RETURNS int
AS
BEGIN
	DECLARE  @Order int;
	SELECT TOP 1 @Order = [PostModeOrder] FROM SGN.TVFGetPostSignSteps(@ProjectId,@CompanyId,@ObjectName)
		WHERE [Role] = @Role
	RETURN @Order;
END


GO
/****** Object:  UserDefinedFunction [SGN].[FnGetRoleReqiredAcceptedBetweenSenderRoleAndReciverRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [SGN].[FnGetRoleReqiredAcceptedBetweenSenderRoleAndReciverRole]
(
	@ProjectId int,
	@CompanyId int,
	@ObjectName varchar(55),
	@ObjectId int,
	@SenderRole varchar(55),
	@ReciverRole varchar(55),
	@SignMode varchar(55)
)
RETURNS varchar(800)
AS
BEGIN
	DECLARE @SenderOrder int
	DECLARE @ReciverOrder int
	SELECT @SenderOrder = SGN.FnGetPostSignRoleOrder(@ProjectId,@CompanyId,@ObjectName,@SenderRole)
	SELECT @ReciverOrder = SGN.FnGetPostSignRoleOrder(@ProjectId,@CompanyId,@ObjectName,@ReciverRole)
	DECLARE @Roles VARCHAR(800) 
	
	IF @SignMode = 'POST'
		BEGIN
			SELECT @Roles = COALESCE(@Roles + ',', '') + [Role]   FROM SGN.TVFGetSignSteps(@ProjectId,@CompanyId,@ObjectName,@SignMode) 
			WHERE [PostModeOrder] > @SenderOrder AND [PostModeOrder] < @ReciverOrder AND [Required] = 1 
			--AND  [Role] NOT IN (SELECT [Role] FROM @T WHERE RowNumber = 1 )
		END

	IF @SignMode = 'BACK'
		BEGIN
			SELECT @Roles = COALESCE(@Roles + ',', '') + [Role]   FROM SGN.TVFGetSignSteps(@ProjectId,@CompanyId,@ObjectName,@SignMode) 
			WHERE [PostModeOrder] < @SenderOrder AND [PostModeOrder] > @ReciverOrder AND [BackRequired] = 1 
			--AND  [Role] NOT IN (SELECT [Role] FROM @T WHERE RowNumber = 1 )
		END

	Return @Roles;
END


GO
/****** Object:  UserDefinedFunction [SGN].[FnGetSignOrderFromNextRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnGetSignOrderFromNextRole]
(
	@SignRequestType varchar(55),
	@ProjectId int,
	@CompanyId int,
	@ObjectName varchar(55),
	@NextRole varchar(55)
)
RETURNS int
AS
BEGIN

	DECLARE @Result int;
	Declare @TempTable As Table(RowNumber int,[PreviousRole] varchar(55),[Role] varchar(55),[NextRole] varchar(55),[Order] int)

	IF Upper(@SignRequestType) = 'POST'
		BEGIN
			DELETE FROM @TempTable
			Insert Into @TempTable Select ROW_NUMBER() Over(
				Partition By ObjectName
				Order By [Order] asc
				) RowNumber, LAG(sg.[Role]) Over(Order By sg.[Order]) [PreviousRole],sg.[Role],LEAD(sg.[Role]) Over(Order By sg.[Order]) [NextRole],[Order]
				From CM.[CMSignConfig] sg
					Where  ProjectId = @ProjectId and (CompanyId IS NULL OR CompanyId = @CompanyId) and ObjectName = @ObjectName

			Select top 1 @Result = [Order] From @TempTable WHERE [NextRole] = @NextRole
	
			RETURN @Result
		END


	IF Upper(@SignRequestType) = 'BACK'
		BEGIN
			DELETE FROM @TempTable
			Insert Into @TempTable Select ROW_NUMBER() Over(
				Partition By ObjectName
				Order By [Order]
				) RowNumber, LAG(sg.[Role]) Over(Order By sg.[Order] desc) [PreviousRole],sg.[Role],LEAD(sg.[Role]) Over(Order By sg.[Order] desc) [NextRole],[Order]
				From CM.[CMSignConfig] sg
					Where  ProjectId = @ProjectId and (CompanyId IS NULL OR CompanyId = @CompanyId) and ObjectName = @ObjectName

			Select top 1 @Result = [Order] From @TempTable WHERE [NextRole] = @NextRole
	
			RETURN @Result
		END

	RETURN -1 -- return -1 when operation faild

END

GO
/****** Object:  UserDefinedFunction [SGN].[FnGetSignRoleFromNextRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnGetSignRoleFromNextRole]
(
	@SignRequestType varchar(55),
	@ProjectId int,
	@CompanyId int,
	@ObjectName varchar(55),
	@NextRole varchar(55)
)
RETURNS varchar(55)
AS
BEGIN

	DECLARE @Result varchar(55);
	Declare @TempTable As Table(RowNumber int,[PreviousRole] varchar(55),[Role] varchar(55),[NextRole] varchar(55),[Order] int)

	IF Upper(@SignRequestType) = 'POST'
		BEGIN
			SET @Result = 'POST'
			DELETE FROM @TempTable
			Insert Into @TempTable Select ROW_NUMBER() Over(
				Partition By ObjectName
				Order By [Order] asc
				) RowNumber, LAG(sg.[Role]) Over(Order By sg.[Order]) [PreviousRole],sg.[Role],LEAD(sg.[Role]) Over(Order By sg.[Order]) [NextRole],[Order]
				From CM.[CMSignConfig] sg
					Where  ProjectId = @ProjectId and (CompanyId IS NULL OR CompanyId = @CompanyId) and ObjectName = @ObjectName

			Select top 1 @Result = [Role] From @TempTable WHERE [NextRole] = @NextRole
	
			RETURN @Result
		END


	IF Upper(@SignRequestType) = 'BACK'
		BEGIN
			SET @Result = 'BACK'
			DELETE FROM @TempTable
			Insert Into @TempTable Select ROW_NUMBER() Over(
				Partition By ObjectName
				Order By [Order]
				) RowNumber, LAG(sg.[Role]) Over(Order By sg.[Order] desc) [PreviousRole],sg.[Role],LEAD(sg.[Role]) Over(Order By sg.[Order] desc) [NextRole],[Order]
				From CM.[CMSignConfig] sg
					Where  ProjectId = @ProjectId and (CompanyId IS NULL OR CompanyId = @CompanyId) and ObjectName = @ObjectName

			Select top 1 @Result = [Role] From @TempTable WHERE [NextRole] = @NextRole
	
			RETURN @Result
		END



	RETURN 'NotFound' -- return notfound when operation is faild!
END

GO
/****** Object:  UserDefinedFunction [SGN].[FnGetSignRoleOrder]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [SGN].[FnGetSignRoleOrder]
(
	@ProjectId int,
	@CompanyId int,
	@ObjectName varchar(55),
	@Role varchar(55)
)
RETURNS int
AS
BEGIN
	DECLARE  @Order int;
	SELECT TOP 1 @Order = [PostModeOrder] FROM SGN.TVFGetPostSignSteps(@ProjectId,@CompanyId,@ObjectName)
		WHERE [Role] = @Role
	RETURN @Order;
END


GO
/****** Object:  UserDefinedFunction [SGN].[FnIsDocumentInSaveMode]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnIsDocumentInSaveMode]
(
	@ObjectId int
)
RETURNS bit
AS
BEGIN

	DECLARE @Count bit = 0;
	
	SELECT  @Count = COUNT(*)  FROM CM.CMDocument WHERE Id = @ObjectId AND Posted = 0

	IF @Count >=1
		RETURN 1
	
	RETURN 0

END


GO
/****** Object:  UserDefinedFunction [SGN].[FnIsFirstSignRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnIsFirstSignRole]
(	
	@ObjectName varchar (55),
	@Role varchar(55),
	@ProjectId int,
	@CompanyId int
)
RETURNS bit
AS
BEGIN
	
	Declare @OrderTempTable As Table(RowNumber int,[PreviousRole] varchar(55),[Role] varchar(55),[NextRole] varchar(55),[Order] int)
	Declare @PreviousRole varchar(55);

	Insert Into @OrderTempTable
		Select ROW_NUMBER() Over(
			Partition By ObjectName
			Order By [Order] asc
			) RowNumber, LAG(sg.[Role]) Over(Order By sg.[Order]) [PreviousRole],sg.[Role],LEAD(sg.[Role]) Over(Order By sg.[Order]) [NextRole],[Order]
			From CM.[CMSignConfig] sg
				Where  ProjectId = @ProjectId and (CompanyId IS NULL OR CompanyId = @CompanyId) and ObjectName = @ObjectName
	Select TOP 1 WITH TIES @PreviousRole = [PreviousRole]  FROM @OrderTempTable
		WHERE [Role] = @Role ORDER BY RowNumber

	IF @PreviousRole IS NULL
		RETURN 1

	RETURN 0
END

GO
/****** Object:  UserDefinedFunction [SGN].[FnIsLastSignRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnIsLastSignRole]
(	
	@ObjectName varchar (55),
	@Role varchar(55),
	@ProjectId int,
	@CompanyId int
)
RETURNS bit
AS
BEGIN
	
	Declare @OrderTempTable As Table(RowNumber int,[Role] varchar(55),[Order] int)
	Declare @NextRole varchar(55);

	Insert Into @OrderTempTable
		Select ROW_NUMBER() Over(
			Partition By ObjectName
			Order By [Order]
			) RowNumber,sg.[Role],[Order]
			From CM.[CMSignConfig] sg
				Where  ProjectId = @ProjectId and (CompanyId IS NULL OR CompanyId = @CompanyId) and ObjectName = @ObjectName
	Select TOP 1 WITH TIES @NextRole = [Role]  FROM @OrderTempTable
		ORDER BY RowNumber DESC

	IF @NextRole = @Role
		RETURN 1

	RETURN 0
END
GO
/****** Object:  UserDefinedFunction [SGN].[FnIsLastSignRoleInPostMode]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnIsLastSignRoleInPostMode]
(	
	@ObjectName varchar (55),
	@Role varchar(55),
	@ProjectId int,
	@CompanyId int
)
RETURNS bit
AS
BEGIN

	DECLARE @Max int
	SELECT  @Max = Max(RowNumber)  FROM SGN.TVFGetPostSignSteps(@ProjectId,@CompanyId,@ObjectName)

	Declare @RowNumber int
	SELECT Top 1  @RowNumber = RowNumber  FROM SGN.TVFGetPostSignSteps(@ProjectId,@CompanyId,@ObjectName)
	WHERE Role = @Role

	if @Max = @RowNumber
		return 1
	
	return 0
	
END


GO
/****** Object:  UserDefinedFunction [SGN].[FnIsLastSignRoleInSendBackMode]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnIsLastSignRoleInSendBackMode]
(	
	@ObjectName varchar (55),
	@Role varchar(55),
	@ProjectId int,
	@CompanyId int
)
RETURNS bit
AS
BEGIN

	DECLARE @Max int
	SELECT  @Max = Max(RowNumber)  FROM SGN.TVFGetBackSignSteps(@ProjectId,@CompanyId,@ObjectName)

	Declare @RowNumber int
	SELECT Top 1  @RowNumber = RowNumber  FROM SGN.TVFGetBackSignSteps(@ProjectId,@CompanyId,@ObjectName)
	WHERE Role = @Role

	if @Max = @RowNumber
		return 1
	
	return 0
	
END


GO
/****** Object:  UserDefinedFunction [SGN].[FnIsPreviousSignStepAccept]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnIsPreviousSignStepAccept]
(
	@ProjectId int,
	@CompanyId int,
	@ObjectName varchar(55),
	@ObjectId int,
	@NextRole varchar(55)
)
RETURNS bit
AS
BEGIN

	Declare @Accecpted int
	Declare @TempTable Table (RowNumber int,[Role] varchar(55),[NextRole] varchar(55),Accepted int,[Order] int,[CreateDate] DateTime,SignMode varchar(55))
	Declare @CurrentRole varchar(255);
	Declare @IsFirstRole bit;
	
	Insert Into @TempTable
		Select Top 1  ROW_NUMBER() Over(
			Partition By s.ObjectName
			Order By [Order] , [CreateDate] desc 
			) RowNumber, s.[Role],s.[NextRole],s.[Accepted],s.[Order],s.CreateDate,Case
					When s.Accepted = 1 THEN 'POST'
					When s.Accepted = 0 THEN 'REJECT'
					When s.Accepted IS NUll THEN 'Back'
				 End SignMode
			From CM.[CMSign] s
				Where  s.ObjectId = @ObjectId AND s.[NextRole] = @NextRole

	Select @Accecpted = [Accepted] , @CurrentRole = [Role] FROM @TempTable

	Set @IsFirstRole = SGN.FnIsFirstSignRole(@ObjectName,@CurrentRole,@ProjectId,@CompanyId)

	IF @IsFirstRole = 1
		RETURN 1;

	IF @Accecpted = 0 OR @Accecpted IS NULL
		RETURN 0
	ELSE
		RETURN 1
		
	RETURN 0
END




GO
/****** Object:  UserDefinedFunction [SGN].[FnNextSignUsersHasAcl]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnNextSignUsersHasAcl]
(
	@ProjectId int,
	@NextUsersId varchar(200),
	@AclName varchar(55)
)
RETURNS int
AS
BEGIN

	Declare @NextRoleUsersIdTable Table(Id int)

	Insert Into @NextRoleUsersIdTable
		Select CAST(value as int) NextRoleUsersId from string_split(@NextUsersId,';')
		Where value <> ''

	DECLARE @TempTable Table(RowNumber int, Id int);
	INSERT INTO @TempTable SELECT ROW_NUMBER() Over(Order By Id) RowNumber,Id FROM @NextRoleUsersIdTable 

	DECLARE @length int;
	Select @length = COUNT(*) From @NextRoleUsersIdTable

	DECLARE @Result bit = 1;

	Declare @i int = 1;
	WHILE (
	@i<= @length
	)
	BEGIN	
		DECLARE @UId int;
		Select @UId = Id FROM @TempTable WHERE RowNumber = @i 
		Select @Result = SGN.FnUserHasAcl(@ProjectId,@UId,@AclName)

		IF @Result = 0 OR @Result IS NULL OR @Result = ''
			BEGIN
				SET @Result = 0
				BREAK
			END
		Set @i = @i + 1
	END

	Return @Result
END

GO
/****** Object:  UserDefinedFunction [SGN].[FnSignRoleNameExist]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnSignRoleNameExist]
(
	@ProjectId int,
	@CompanyId int,
	@ObjectName varchar(55),
	@Role varchar(55)
)
RETURNS bit
AS
BEGIN
	
	DECLARE @Result varchar(55)

	SELECT @Result = [Role] FROM SGN.TVFGetPostSignSteps(@ProjectId,@CompanyId,@ObjectName)  WHERE [Role] = @Role

	IF @Result IS NULL
		RETURN 0
	ELSE
		RETURN 1

	RETURN 0
END

GO
/****** Object:  UserDefinedFunction [SGN].[FnUserHasAcl]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnUserHasAcl]
(
	@ProjectId int,
	@UserId int,	
	@AclName varchar(55)
)
RETURNS int
AS
BEGIN
	DECLARE @UserAllow AS INT
	DECLARE @GroupAllow As INT
	DECLARE @Result AS INT

	----- در این قسمت دسترسی مربوط به کاربر بررسی میشود	
	SELECT @UserAllow = Allow
	FROM [CMIS].[CM].[CMAcl] acl
	where [ProjectId]= @ProjectId and UserId = @UserId and [Name]= @AclName

	----- در این قسمت دسترسی مربوط به گروه بررسی میشود
	select TOP 1 @GroupAllow = Allow
	from CM.CMAcl acl
	join CM.UsersGroups ugs on ugs.GroupId = acl.GroupId
	where acl.[ProjectId]=@ProjectId  and ugs.UserId = @UserId and acl.[Name]= @AclName
	ORder BY acl.Allow Desc

	IF @UserAllow IS NULL
		SET @Result = @GroupAllow
	ELSE 
		SET @Result = @UserAllow

	IF @Result IS NULL
		SET @Result = 0

	RETURN @Result
END

GO
/****** Object:  UserDefinedFunction [SGN].[FnUsersHasSignRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[FnUsersHasSignRole]
(
	@ProjectId int,
	@UsersId varchar(200), -- You send fil this parameter like -> '1;2;3;4;5;'
	@ObjectName varchar(55),
	@AclRoleName varchar(55),
	@Role varchar(55)
)
RETURNS bit
AS
BEGIN
	Declare @NextRoleUsersIdTable Table(Id int)

	Insert Into @NextRoleUsersIdTable
		Select CAST(value as int) NextRoleUsersId from string_split(@UsersId,';')
		Where value <> ''

	DECLARE @TempTable Table(RowNumber int, Id int);
	INSERT INTO @TempTable SELECT ROW_NUMBER() Over(Order By Id) RowNumber,Id FROM @NextRoleUsersIdTable 

	DECLARE @length int;
	Select @length = COUNT(*) From @NextRoleUsersIdTable


	Declare @COUNT int = 0;
	DECLARE @Result bit = 1;

	Declare @i int = 1;
	WHILE (
	@i<= @length
	)
	BEGIN	
		DECLARE @UId int;
		Select @UId = Id FROM @TempTable WHERE RowNumber = @i 
		Select @COUNT = COUNT(*) From SGN.TVFGetUserSignRoles(@ProjectId,@UId,@AclRoleName,@ObjectName) where [Role] = @Role
		IF @COUNT = 0
			BEGIN
				Set @Result = 0;
				BREAK
			END
		Set @i = @i + 1
	END

	RETURN @Result

END

GO
/****** Object:  UserDefinedFunction [SGN].[TVFGetBackSignSteps]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[TVFGetBackSignSteps]
(
	@ProjectId int,
	@CompanyId int,
	@ObjectName varchar(55)
)
RETURNS 
@T TABLE 
(
	RowNumber int,
	Id int,
	ProjectId int,
	ObjectName varchar(55),
	PreviousRole varchar(55),
	[Role] varchar(55),
	NextRole varchar(55),
	[PostModeOrder] int,
	[BackModeOrder] int,
	[CompanyId] int,
	[BackRequired] bit
)
AS
BEGIN
	
	Insert Into @T SELECT 
		ROW_NUMBER() Over(
				Partition By ObjectName
				Order By [Order] desc
				) RowNumber
				,Id,ProjectId,ObjectName,LAG([Role]) Over (Order By [Order] desc) PreviousRole,[Role],LEAD([Role]) Over (Order By [Order] desc) NextRole,[Order],[RejectOrder],CompanyId,[BackRequired]
		FROM  CM.CMSignConfig 


		WHERE [ProjectId] = @ProjectId AND [ObjectName] = @ObjectName AND ([CompanyId] = @CompanyId  OR [CompanyId] IS NULL)

	
	RETURN 
END
GO
/****** Object:  UserDefinedFunction [SGN].[TVFGetPostSignSteps]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[TVFGetPostSignSteps]
(
	@ProjectId int,
	@CompanyId int,
	@ObjectName varchar(55)
)
RETURNS 
@T TABLE 
(
	RowNumber int,
	Id int,
	ProjectId int,
	ObjectName varchar(55),
	PreviousRole varchar(55),
	[Role] varchar(55),
	NextRole varchar(55),
	[PostModeOrder] int,
	[BackModeOrder] int,
	[CompanyId] int,
	[Required] bit
)
AS
BEGIN
	
	Insert Into @T SELECT 
		ROW_NUMBER() Over(
				Partition By ObjectName
				Order By [Order] asc
				) RowNumber
				,Id,ProjectId,ObjectName,LAG([Role]) Over (Order By [Order]) PreviousRole,[Role],LEAD([Role]) Over (Order By [Order]) NextRole,[Order],[RejectOrder],CompanyId,[Required] 
		[Required]
		FROM  CM.CMSignConfig 

		WHERE [ProjectId] = @ProjectId AND [ObjectName] = @ObjectName AND ([CompanyId] = @CompanyId  OR [CompanyId] IS NULL)

	
	RETURN 
END
GO
/****** Object:  UserDefinedFunction [SGN].[TVFGetPreviousSignRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[TVFGetPreviousSignRole] 
(
	@ProjectId as int,
	@ObjectName as varchar(55),
	@ObjectId as int,
	@CompanyId as int = NULL
)
RETURNS 
@T TABLE 
(
	[Role] varchar(55),
	[NextRole] varchar(55),
	[Order] int
)
AS
BEGIN

	Declare @NextRole as varchar(55)

	Declare @OrderTempTable As Table(RowNumber int,[PreviousRole] varchar(55),[Role] varchar(55),[NextRole] varchar(55),[Order] int)

	Select @NextRole = [DocumentOwnersRole] From CM.[CMDocument]
		Where Id = @ObjectId

	Insert Into @OrderTempTable
		Select ROW_NUMBER() Over(
			Partition By ObjectName
			Order By [Order] desc
			) RowNumber, LAG(sg.[Role]) Over(Order By sg.[Order] desc) Befor,sg.[Role],LEAD(sg.[Role]) Over(Order By sg.[Order] desc) [Next],[Order]
			From CM.[CMSignConfig] sg
				Where  ProjectId = @ProjectId and (CompanyId IS NULL OR CompanyId = @CompanyId) and ObjectName = @ObjectName
					
	Insert Into @T 
		Select Top 1 With Ties [Role],[NextRole],[Order] From @OrderTempTable Where [Role] = @NextRole  Order By RowNumber Asc
	
	RETURN 
END

GO
/****** Object:  UserDefinedFunction [SGN].[TVFGetSignSteps]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [SGN].[TVFGetSignSteps]
(
	@ProjectId int,
	@CompanyId int,
	@ObjectName varchar(55),
	@SignMode varchar(55)
	
)
RETURNS 
@T TABLE 
(
	RowNumber int,
	Id int,
	ProjectId int,
	ObjectName varchar(55),
	PreviousRole varchar(55),
	[Role] varchar(55),
	NextRole varchar(55),
	[PostModeOrder] int,
	[BackModeOrder] int,
	[CompanyId] int,
	[Required] bit,
	[BackRequired] bit
)
AS
BEGIN
	IF @SignMode = 'post'
		BEGIN
			Insert Into @T SELECT 
				ROW_NUMBER() Over(
						Partition By ObjectName
						Order By [Order] asc
						) RowNumber
						,Id,ProjectId,ObjectName,LAG([Role]) Over (Order By [Order]) PreviousRole,[Role],LEAD([Role]) Over (Order By [Order]) NextRole,[Order],[RejectOrder],CompanyId,[Required],[BackRequired]
				[Required]
				FROM  CM.CMSignConfig 

				WHERE [ProjectId] = @ProjectId AND [ObjectName] = @ObjectName AND ([CompanyId] = @CompanyId  OR [CompanyId] IS NULL)
		END


	If @SignMode = 'back'
		BEGIN
			Insert Into @T SELECT 
				ROW_NUMBER() Over(
						Partition By ObjectName
						Order By [Order] desc
						) RowNumber
						,Id,ProjectId,ObjectName,LAG([Role]) Over (Order By [Order] desc) PreviousRole,[Role],LEAD([Role]) Over (Order By [Order] desc) NextRole,[Order],[RejectOrder],CompanyId,[Required],[BackRequired] 
				[Required]
				FROM  CM.CMSignConfig 

				WHERE [ProjectId] = @ProjectId AND [ObjectName] = @ObjectName AND ([CompanyId] = @CompanyId  OR [CompanyId] IS NULL)
		END
	
	RETURN 
END
GO
/****** Object:  UserDefinedFunction [SGN].[TVFGetUserDisciplines]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [SGN].[TVFGetUserDisciplines]
(
	@ProjectId int,
	@UserId int,
	@Acl varchar(200)
)
RETURNS 
@T TABLE 
(
	Id int,
	Symbol varchar(50),
	Discipline varchar(200)
)
AS
BEGIN
	Insert Into @T SELECT ou.Id,ou.Symbol, ou.[Name] from CM.CMAclItem acli
		inner join CM.CMAcl acl on acl.Id = acli.AclId
		inner join CM.OrganizationUnit ou on ou.Id = acli.[Value]
		where acl.ProjectId =@ProjectId and acl.UserId= @UserId and acl.[Name]=@Acl and acl.Allow=1

	Insert Into @T SELECT ou.Id,ou.Symbol, ou.[Name]from CM.CMAclItem acli
		inner join CM.CMAcl acl on acl.Id = acli.AclId
		inner join CM.UsersGroups ugs on ugs.GroupId = acl.GroupId
		inner join CM.OrganizationUnit ou on ou.Id = acli.[Value]
		where acl.ProjectId =@ProjectId and ugs.UserId= @UserId and acl.[Name]=@Acl and acl.Allow=1
		order by ou.Id
	
	RETURN 
END

GO
/****** Object:  UserDefinedFunction [SGN].[TVFGetUserSignRoles]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [SGN].[TVFGetUserSignRoles]
(
	@ProjectId int,
	@UserId int,
	@RoleAclName varchar(55),
	@ObjectName varchar(55)
)
RETURNS
@SignRolesTable TABLE 
(
	ObjectName varchar(55),
	[Role] varchar(55)
)
AS
BEGIN
	-- Fill the table variable with the rows for your result set
	Declare  @UserRole as Table(ObjectName varchar(55),[Role] varchar(55));
	-- Cte for get acl result from user
	With CteAclX
	As(
		Select * From CM.CMAcl acl where acl.ProjectId = @ProjectId and acl.UserId= @UserId
	)Insert Into @UserRole
	Select sc.[Objectname],sc.[Role] From CteAclX cax
		join CM.CMAclItem acli on acli.AclId = cax.Id
		join CM.CMSignConfig sc on sc.Id = acli.[Value]
		where sc.ObjectName = @ObjectName AND cax.Allow = 1

	--Cte for get result from user group
	;With CteUsersGroups
	As(
		Select * From Cm.UsersGroups where UserId = @UserId
	)Insert INTO @UserRole
	select sc.[Objectname],sc.[Role] from CteUsersGroups cugs
		join CM.CMAcl acl on acl.GroupId = cugs.GroupId
		join CM.CMAclItem acli on acli.AclId = acl.Id
		join CM.CMSignConfig sc on sc.Id = acli.[Value]
		where sc.ObjectName = @ObjectName And acl.Allow = 1

	Insert Into @SignRolesTable 
		Select Distinct * From @UserRole

	RETURN
END

GO
/****** Object:  Table [CM].[Area]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[Area](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[Name] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Area] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[ChangeLog]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[ChangeLog](
	[Id] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[TableName] [varchar](20) NOT NULL,
	[TableRow] [int] NOT NULL,
	[Action] [varchar](10) NOT NULL,
	[OnDate] [datetime] NOT NULL,
	[Description] [varchar](100) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[City]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[City](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[EnName] [varchar](50) NULL,
	[ProvinceId] [int] NOT NULL,
	[NationalCode] [varchar](20) NULL,
	[IsDelete] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[CMAcl]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[CMAcl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Value] [int] NULL,
	[Allow] [bit] NULL,
	[GroupId] [int] NULL,
	[UserId] [int] NULL,
	[Description] [nvarchar](100) NULL,
	[ProjectId] [int] NULL,
 CONSTRAINT [PK_Acl] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[CMAclItem]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[CMAclItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AclId] [int] NOT NULL,
	[Value] [int] NOT NULL,
 CONSTRAINT [PK_AclItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[CMAttachments]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[CMAttachments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[ObjectName] [nvarchar](50) NOT NULL,
	[ObjectId] [int] NOT NULL,
	[stream_id] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedUserId] [int] NULL,
	[IsDelete] [bit] NOT NULL,
	[IsUsed] [bit] NULL,
	[CustomType] [nvarchar](50) NULL,
	[FileType] [varchar](10) NULL,
	[FileName] [nvarchar](150) NULL,
	[Remark] [nvarchar](200) NULL,
	[DeletedDate] [datetime] NULL,
	[DeletedUserId] [int] NULL,
	[DeletedOn] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[Type] [nvarchar](50) NULL,
 CONSTRAINT [PK_Attachments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[CMConfig]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[CMConfig](
	[Id] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[Scope] [varchar](50) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Value] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_CM.CMConfig] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[CMDocument]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[CMDocument](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[ReportNo] [varchar](255) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[Posted] [bit] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Complete] [bit] NOT NULL,
	[Accepted] [bit] NOT NULL,
	[CompanyId] [int] NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[DisciplineId] [int] NULL,
	[ContractorId] [int] NULL,
	[ContractId] [int] NULL,
	[UnitId] [int] NULL,
	[Type2] [varchar](50) NULL,
	[Remark] [nvarchar](300) NULL,
	[DocumentOwnersRole] [varchar](50) NULL,
	[Approved] [int] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[IsVoid] [bit] NOT NULL,
	[PostedOn] [datetime] NULL,
	[UId] [int] NULL,
	[DCCStatus] [varchar](40) NULL,
	[DCCStatusChangeDate] [datetime] NULL,
	[DCCStatusChangeUser] [int] NULL,
	[DCCRemark] [nvarchar](300) NULL,
	[DeletedBy] [int] NULL,
	[DeletedOn] [datetime] NULL,
	[VoidedBy] [int] NULL,
	[VoidedOn] [datetime] NULL,
	[RevNo] [varchar](10) NULL,
	[DCCNextRole] [varchar](50) NULL,
	[DCCNextRoleExpireDate] [datetime] NULL,
	[DCCLastSignDate] [datetime] NULL,
 CONSTRAINT [PK_Document] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[CMReportNumber]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[CMReportNumber](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FormatValue] [varchar](150) NOT NULL,
	[UniqueValue] [varchar](150) NULL,
	[FormatId] [int] NOT NULL,
	[Counter] [int] NOT NULL,
 CONSTRAINT [PK_CMReportNo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[CMReportSyntax]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[CMReportSyntax](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[DisciplineId] [int] NULL,
	[EmployerId] [int] NULL,
	[Format] [varchar](150) NOT NULL,
	[ObjectName] [varchar](50) NOT NULL,
	[Digits] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_CMReportFormat] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [uniqueFormat] UNIQUE NONCLUSTERED 
(
	[ProjectId] ASC,
	[DisciplineId] ASC,
	[EmployerId] ASC,
	[Format] ASC,
	[ObjectName] ASC,
	[IsActive] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[CMSign]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[CMSign](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[ObjectName] [varchar](50) NOT NULL,
	[ObjectId] [int] NOT NULL,
	[Role] [varchar](50) NOT NULL,
	[RoleUserId] [int] NULL,
	[CreateDate] [datetime] NOT NULL,
	[Accepted] [bit] NULL,
	[Order] [int] NOT NULL,
	[Remark] [nvarchar](2000) NULL,
	[NextRole] [varchar](50) NULL,
	[NextRoleUsersId] [varchar](250) NULL,
	[MachineName] [nvarchar](150) NULL,
	[ActiveDirectoryName] [nvarchar](250) NULL,
	[LoggedUserId] [int] NULL,
	[CompanyId] [int] NULL,
	[IsSeen] [bit] NOT NULL,
	[SeenUser] [int] NULL,
	[SeenDate] [datetime] NULL,
 CONSTRAINT [PK_Sign] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[CMSignConfig]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[CMSignConfig](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[ObjectName] [varchar](50) NOT NULL,
	[Role] [varchar](50) NOT NULL,
	[Order] [int] NOT NULL,
	[RejectOrder] [int] NULL,
	[CompanyId] [int] NULL,
	[Required] [bit] NULL,
	[BackRequired] [bit] NULL,
 CONSTRAINT [PK_SignConfig] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[Company]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[Company](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Symbol] [varchar](30) NULL,
	[FullName] [nvarchar](133) NOT NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[CompanyUnits]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[CompanyUnits](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[EnName] [nvarchar](100) NULL,
	[IsDelete] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_Unit_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[Config]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[Config](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[Scope] [varchar](50) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Value] [nvarchar](500) NULL,
 CONSTRAINT [PK_Config] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[Contract]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[Contract](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployerId] [int] NOT NULL,
	[ContractorId] [int] NOT NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[ProjectId] [int] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Contract] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[Counter]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[Counter](
	[Name] [varchar](100) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[Counter] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[Countries]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[EnName] [varchar](50) NULL,
	[IsDelete] [int] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[Country]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[Country](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[UserId] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[DisciplineMap]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[DisciplineMap](
	[Id] [int] NOT NULL,
	[CMISId] [int] NOT NULL,
	[MasterId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[DWG]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[DWG](
	[Id] [int] NOT NULL,
	[DwgNo] [varchar](100) NOT NULL,
	[RevNo] [varchar](100) NOT NULL,
	[Tag] [varchar](100) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[Family]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[Family](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Family] [nvarchar](50) NULL,
 CONSTRAINT [PK_Family] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[FileTest]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[FileTest](
	[Content] [varbinary](max) NULL,
	[FileName] [nvarchar](255) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [CM].[Form]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[Form](
	[Id] [int] NOT NULL,
	[ProjectId] [int] NULL,
	[ContractorId] [int] NULL,
	[ContractId] [int] NULL,
	[DisciplineId] [int] NULL,
	[CreatorId] [int] NULL,
	[ReportNo] [varchar](30) NULL,
	[Type] [varchar](30) NULL,
	[Type2] [varchar](30) NULL,
	[NextSignRole] [varchar](50) NULL,
	[Complete] [bit] NULL,
	[Accept] [bit] NULL,
	[Remark] [nvarchar](500) NULL,
	[IsPost] [bit] NULL,
	[CreateDate] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[GridDescription]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[GridDescription](
	[Id] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[SoftwareId] [int] NOT NULL,
	[Form] [varchar](500) NOT NULL,
	[Section] [varchar](500) NULL,
	[Grid] [varchar](500) NOT NULL,
	[Column] [varchar](500) NOT NULL,
	[PersianDescription] [nvarchar](500) NULL,
	[EnglishDescription] [varchar](500) NULL,
	[Formula] [varchar](500) NULL,
	[FilterBy] [varchar](500) NULL,
	[CreateDate] [datetime] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[JalaliDate]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[JalaliDate](
	[MiladiDate] [date] NOT NULL,
	[JalaliDate] [char](10) NOT NULL,
 CONSTRAINT [PK_JalaliDate] PRIMARY KEY CLUSTERED 
(
	[MiladiDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[JobPosition]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[JobPosition](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[EnName] [varchar](100) NULL,
	[IsDelete] [int] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_JobPosition] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[Message]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[Message](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](500) NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[CreatorId] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[ExpireDate] [datetime] NULL,
	[Color] [nvarchar](10) NOT NULL,
	[LastEditDate] [datetime] NULL,
	[IsDelete] [bit] NULL,
	[IsActive] [bit] NULL,
	[IsTrayMessage] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [CM].[MessageFilter]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[MessageFilter](
	[Id] [int] NOT NULL,
	[MessageId] [int] NULL,
	[GroupId] [int] NULL,
	[UserId] [int] NULL,
	[CompanyId] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[Messages]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[Messages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Message] [nvarchar](255) NOT NULL,
	[Lang] [varchar](10) NOT NULL,
	[Type] [varchar](50) NULL,
	[ProjectId] [int] NULL,
 CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[Name]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[Name](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Name] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[OrganizationUnit]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[OrganizationUnit](
	[Id] [int] NOT NULL,
	[IsDiscipline] [bit] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[ParentId] [int] NULL,
	[Symbol] [varchar](10) NULL,
	[Name] [nvarchar](70) NOT NULL,
	[ReportSymbol] [varchar](10) NULL,
 CONSTRAINT [PK_OrganizationUnit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[Project]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[Project](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Code] [varchar](20) NOT NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[Active] [bit] NOT NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[Province]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[Province](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[EnName] [varchar](50) NULL,
	[CountryId] [int] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_Province] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[ReportFormat]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[ReportFormat](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[DisciplineId] [int] NOT NULL,
	[Format] [varchar](100) NOT NULL,
	[Digits] [int] NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[UniqueByType] [bit] NOT NULL,
	[UniqueByCompany] [bit] NOT NULL,
	[UniqueByEmployer] [bit] NOT NULL,
	[EmployerId] [int] NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_ReportFormat] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[ReportNo]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[ReportNo](
	[Id] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[CompanyId] [int] NULL,
	[EmployerId] [int] NULL,
	[DisciplineId] [int] NULL,
	[Type] [varchar](50) NOT NULL,
	[Count] [int] NOT NULL,
	[CustomType] [nvarchar](50) NULL,
	[UniqueByCompany] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[SignImage]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[SignImage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[SignName] [varchar](150) NOT NULL,
	[SignImage] [varbinary](max) NOT NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_SignImage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [CM].[Unit]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[Unit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AreaId] [int] NOT NULL,
	[Name] [varchar](10) NOT NULL,
	[Abbreviation] [nvarchar](100) NULL,
	[Description] [nvarchar](100) NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[User]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[LastPasswordChange] [datetime] NULL,
	[FirstName] [nvarchar](20) NULL,
	[LastName] [nvarchar](20) NULL,
	[FullName] [nvarchar](41) NOT NULL,
	[enFirstName] [nvarchar](20) NULL,
	[enLastName] [nvarchar](20) NULL,
	[enFullName] [nvarchar](42) NOT NULL,
	[LastLoginDate] [datetime] NULL,
	[LastLoginIp] [varchar](20) NULL,
	[Active] [bit] NOT NULL,
	[JobTitle] [nvarchar](100) NULL,
	[ProfileImage] [varbinary](max) NULL,
	[LoggedIn] [bit] NOT NULL,
	[LastLogoutDate] [datetime] NULL,
	[MustToChangePassword] [bit] NOT NULL,
	[SignImage] [varbinary](max) NULL,
	[SignImageTQ] [varbinary](max) NULL,
	[SignName] [nvarchar](150) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [CM].[UserGroup]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[UserGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[ProjectId] [int] NULL,
 CONSTRAINT [PK_UserGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[UsersGroups]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[UsersGroups](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[GroupId] [int] NOT NULL,
 CONSTRAINT [PK_UsersGroups] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [CM].[VersionDescription]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CM].[VersionDescription](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[DisciplineId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[StreemID] [uniqueidentifier] NOT NULL,
	[Version] [varchar](20) NOT NULL,
	[Description] [varchar](200) NULL,
	[Type] [varchar](20) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_VersionDescription] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FileSource]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FileSource](
	[stream_id] [int] IDENTITY(1,1) NOT NULL,
	[FileName] [nvarchar](50) NULL,
 CONSTRAINT [PK_FileSource] PRIMARY KEY CLUSTERED 
(
	[stream_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FileTarget]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FileTarget](
	[stream_id] [int] IDENTITY(1,1) NOT NULL,
	[FileName] [nvarchar](50) NULL,
 CONSTRAINT [PK_FileTarget] PRIMARY KEY CLUSTERED 
(
	[stream_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Source]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Source](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[FileId] [int] NULL,
 CONSTRAINT [PK_Source] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Target]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Target](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[FileId] [int] NULL,
 CONSTRAINT [PK_Target] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [EL].[Category]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [EL].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ParentId] [int] NULL,
	[Category] [nvarchar](100) NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [EL].[InventoryBalance]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [EL].[InventoryBalance](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[UnitId] [int] NOT NULL,
	[ItemCodeId] [int] NOT NULL,
	[Recieve] [decimal](18, 2) NOT NULL,
	[Reserve] [decimal](18, 2) NOT NULL,
	[Issue] [decimal](18, 2) NOT NULL,
	[Return] [decimal](18, 2) NOT NULL,
	[Inventory]  AS (([Recieve]-[Issue])+[Return]) PERSISTED,
	[Balance]  AS ((([Recieve]-[Issue])+[Return])-[Reserve]) PERSISTED,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_InventoryBalance] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [EL].[ItemCode]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [EL].[ItemCode](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[WarehouseItemCodeId] [int] NULL,
	[CategoryId] [int] NULL,
	[ItemCode] [varchar](150) NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_ItemCode] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [EL].[Packing]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [EL].[Packing](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocumentId] [int] NOT NULL,
	[ItemCodeId] [int] NOT NULL,
	[UnitId] [int] NULL,
	[VendorId] [int] NOT NULL,
	[TagNo] [varchar](100) NULL,
	[CategoryId] [int] NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Size] [varchar](50) NOT NULL,
	[PackingNo] [varchar](100) NOT NULL,
	[PLQty] [decimal](18, 2) NOT NULL,
	[QtyUnitId] [int] NOT NULL,
 CONSTRAINT [PK_Packing] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [EL].[PLQtyUnit]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [EL].[PLQtyUnit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Unit] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PLQtyUnit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [EL].[WarehouseItemCode]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [EL].[WarehouseItemCode](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemCode] [varchar](100) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [GatePass].[Attachment]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GatePass].[Attachment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocumentId] [int] NOT NULL,
	[GatePassId] [int] NOT NULL,
	[AttachmentId] [int] NOT NULL,
	[PersonContractId] [int] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [nchar](10) NULL,
 CONSTRAINT [PK_Attachment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [GatePass].[BlackList]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GatePass].[BlackList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NationalCode] [char](10) NOT NULL,
	[Remark] [nvarchar](500) NULL,
	[CreatedUser] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_BlackList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [GatePass].[FaceIdentificationPlace]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GatePass].[FaceIdentificationPlace](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[EnName] [varchar](50) NULL,
	[IsDelete] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_FaceIdentificationPlace] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [GatePass].[ftAttachmentGatePass]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ARITHABORT ON
GO
CREATE TABLE [GatePass].[ftAttachmentGatePass] AS FILETABLE ON [PRIMARY] FILESTREAM_ON [GatePassDocumentStore]
WITH
(
FILETABLE_DIRECTORY = N'GatePassDocumentStore', FILETABLE_COLLATE_FILENAME = Arabic_CI_AS
)

GO
/****** Object:  Table [GatePass].[GatePass]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GatePass].[GatePass](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocumentId] [int] NOT NULL,
	[PersonContractId] [int] NOT NULL,
	[RequestTypeId] [int] NOT NULL,
	[UnitRequestId] [int] NOT NULL,
	[Unit] [nvarchar](100) NOT NULL,
	[AttendanceDate] [datetime] NOT NULL,
	[AttendanceDuration] [int] NOT NULL,
	[GatePassTypeId] [int] NOT NULL,
	[JobPositionId] [int] NOT NULL,
	[JobPosition] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](400) NULL,
	[IsDelete] [bit] NOT NULL,
	[IsRevoke] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_GatePassDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [GatePass].[GatePassDetail]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GatePass].[GatePassDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocumentId] [int] NOT NULL,
	[GatePassId] [int] NOT NULL,
	[RoleOrder] [int] NOT NULL,
	[Accept] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_GatePassDetail_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [GatePass].[GatePassRequestHistory]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GatePass].[GatePassRequestHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[DocumentId] [int] NOT NULL,
	[GatePassId] [int] NOT NULL,
	[RoleId] [int] NULL,
	[AttendanceDuration_S] [int] NULL,
	[AttendanceDuration] [int] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GatePassRequestHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [GatePass].[GatePassType]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GatePass].[GatePassType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[EnName] [varchar](50) NULL,
	[Color] [varchar](50) NULL,
	[IsDelete] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_GatePassType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [GatePass].[LetterRequest]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GatePass].[LetterRequest](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocumentId] [int] NOT NULL,
	[PersonId] [int] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_SatisfactionLetter] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [GatePass].[Person]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GatePass].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[UnitId] [int] NOT NULL,
	[JobPositionId] [int] NOT NULL,
	[NationalCode] [char](10) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[EnFirstName] [varchar](50) NULL,
	[LastName] [nvarchar](60) NOT NULL,
	[EnLastName] [varchar](50) NULL,
	[FatherName] [nvarchar](50) NOT NULL,
	[EnFatherName] [varchar](50) NULL,
	[GenderId] [int] NOT NULL,
	[CardCode] [varchar](10) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[BirthCityId] [int] NOT NULL,
	[CardIssuanceCityId] [int] NOT NULL,
	[FatherBirthCityId] [int] NULL,
	[MotherBirthCityId] [int] NULL,
	[NativeCode] [int] NULL,
	[Identifier] [nvarchar](100) NULL,
	[TrackingCode] [varchar](200) NULL,
	[MobileNo] [varchar](14) NULL,
	[PhoneNo] [varchar](20) NULL,
	[Address] [nvarchar](200) NULL,
	[IsDelete] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [GatePass].[PersonContract]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GatePass].[PersonContract](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonId] [int] NOT NULL,
	[ContractId] [int] NOT NULL,
	[PersonCode] [nvarchar](10) NULL,
	[Date OfEmployeement] [datetime] NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_PersonContractors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [GatePass].[PersonFaceIdentification]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GatePass].[PersonFaceIdentification](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FaceIdentificationId] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[Accept] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [GatePass].[PersonHistory]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GatePass].[PersonHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NULL,
	[ProjectId] [int] NOT NULL,
	[PersonContractId] [int] NOT NULL,
	[PersonId] [int] NOT NULL,
	[JobPositionId_S] [int] NULL,
	[JobpositionId] [int] NULL,
	[JobPosition_S] [nvarchar](100) NULL,
	[JobPosition] [nvarchar](100) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_PersonHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [GatePass].[Settings]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GatePass].[Settings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[CompanyId] [int] NULL,
	[Name] [varchar](55) NOT NULL,
	[Value] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Settings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [JobReport].[ftAttachmentJobReport]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ARITHABORT ON
GO
CREATE TABLE [JobReport].[ftAttachmentJobReport] AS FILETABLE ON [PRIMARY] FILESTREAM_ON [JRDocumentStore]
WITH
(
FILETABLE_DIRECTORY = N'JRDocumentStore', FILETABLE_COLLATE_FILENAME = Arabic_CI_AS
)

GO
/****** Object:  Table [JobReport].[JobReport]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [JobReport].[JobReport](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ReportNumber] [varchar](200) NOT NULL,
	[ObjectId] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[DisciplineId] [int] NULL,
	[CompanyId] [int] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
	[IsDelete] [bit] NULL,
	[IsVoid] [bit] NULL,
	[ReportDate] [datetime] NOT NULL,
	[UserEmail] [nvarchar](200) NULL,
	[ReportContent] [nvarchar](max) NOT NULL,
	[ProblemsContent] [nvarchar](max) NOT NULL,
	[Suggestion] [nvarchar](max) NULL,
 CONSTRAINT [PK_JobReport] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [Notify].[ftAttachmentNotify]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ARITHABORT ON
GO
CREATE TABLE [Notify].[ftAttachmentNotify] AS FILETABLE ON [PRIMARY] FILESTREAM_ON [NotifyDocumentStore]
WITH
(
FILETABLE_DIRECTORY = N'NotifyDocumentStore', FILETABLE_COLLATE_FILENAME = Arabic_CI_AS
)

GO
/****** Object:  Table [Notify].[NotificationDetail]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Notify].[NotificationDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_NotificationDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Notify].[NotificationDetatilAttachment]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Notify].[NotificationDetatilAttachment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NotifyDetailId] [int] NOT NULL,
	[StreamId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_NotificationDetatilAttachment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Notify].[NotifyActiveUser]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Notify].[NotifyActiveUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[MachineName] [nvarchar](200) NULL,
	[ActiveDirectoryName] [nvarchar](200) NULL,
	[IpAddress] [varchar](15) NULL,
	[NotifyData] [varbinary](max) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_NotifyActiveUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [Notify].[NotifyUsers]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Notify].[NotifyUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[MachineName] [nvarchar](200) NULL,
	[ActiveDirectoryName] [nvarchar](200) NULL,
	[IpAddress] [varchar](15) NULL,
	[LastCheckDate] [datetime] NULL,
 CONSTRAINT [PK_NotifyUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [QCEL].[CF]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [QCEL].[CF](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CFTypeId] [int] NOT NULL,
	[DocumentId] [int] NOT NULL,
	[RevisionId] [bigint] NULL,
	[Location] [nvarchar](100) NULL,
	[VoltageCableType] [int] NULL,
 CONSTRAINT [PK_CF] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [QCEL].[CFItems]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [QCEL].[CFItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[CFTypeId] [nchar](10) NULL,
	[CFType] [varchar](50) NOT NULL,
	[Order] [int] NOT NULL,
 CONSTRAINT [PK_CFItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [QCEL].[CFItemsResult]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [QCEL].[CFItemsResult](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CFId] [int] NOT NULL,
	[RoleOrder] [int] NULL,
	[ItemId] [int] NOT NULL,
	[ItemValue] [int] NULL,
	[CreatedBy] [int] NOT NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_CFItemsResult] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [QCEL].[ftAttachment]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ARITHABORT ON
GO
CREATE TABLE [QCEL].[ftAttachment] AS FILETABLE ON [PRIMARY] FILESTREAM_ON [QCElectricalDocumentStore]
WITH
(
FILETABLE_DIRECTORY = N'[QCElectricalDocumentStore]', FILETABLE_COLLATE_FILENAME = Latin1_General_100_CI_AS
)

GO
/****** Object:  Table [QCElectrical].[CF_800]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [QCElectrical].[CF_800](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DWGNo] [varchar](100) NOT NULL,
	[REVNo] [varchar](50) NOT NULL,
	[TAGNo] [varchar](50) NOT NULL,
	[TypeOfInspection] [nvarchar](max) NOT NULL,
	[InspectionItem] [nvarchar](max) NOT NULL,
	[InspectionResult] [nvarchar](max) NOT NULL,
	[Remarks] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_CF_800] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [QCElectrical].[CF_801_1]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [QCElectrical].[CF_801_1](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DWGNo] [varchar](100) NOT NULL,
	[REVNo] [varchar](50) NOT NULL,
	[TAGNo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CF_801_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [QCElectrical].[CF_801_3]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [QCElectrical].[CF_801_3](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DWGNo] [varchar](100) NOT NULL,
	[REVNo] [varchar](50) NOT NULL,
	[RACNo] [varchar](500) NOT NULL,
 CONSTRAINT [PK_CF_801_3] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [QCElectrical].[CF_803]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [QCElectrical].[CF_803](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DWGNo] [varchar](100) NOT NULL,
	[REVNo] [varchar](50) NOT NULL,
	[TAGNo] [varchar](50) NOT NULL,
	[LOCATION] [varchar](50) NOT NULL,
	[TYPE] [varchar](50) NOT NULL,
	[CAPACITY] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_CF_803] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [QCElectrical].[CF_806]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [QCElectrical].[CF_806](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DWGNo] [varchar](100) NOT NULL,
	[REVNo] [varchar](50) NOT NULL,
	[TAGNo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CF_806] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [QCElectrical].[CF_808]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [QCElectrical].[CF_808](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DWGNo] [varchar](100) NOT NULL,
	[REVNo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CF_808] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [QCElectrical].[CF809]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [QCElectrical].[CF809](
	[Id] [int] NOT NULL,
	[DWGNo] [varchar](55) NOT NULL,
	[GrandingWeld/EarthingRod] [nvarchar](200) NULL,
	[GroundingResistanceIndividual] [nvarchar](200) NULL,
	[GorundingResistanceNotDefinedByQC] [nvarchar](200) NULL,
	[Inspection] [bit] NULL,
	[Comment] [nvarchar](500) NULL,
 CONSTRAINT [PK_CF809] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [QCElectrical].[CF849]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [QCElectrical].[CF849](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocumentId] [int] NOT NULL,
	[DWGNo] [varchar](100) NOT NULL,
	[Location] [nvarchar](100) NULL,
	[UnitId] [int] NOT NULL,
	[LocationRouteFrom] [nvarchar](100) NULL,
	[LocationrouteTo] [nvarchar](100) NULL,
	[Size/Type] [varchar](10) NULL,
	[Length(MT.)] [varchar](10) NULL,
	[HadlingIsSatisfactoryAndNoPhysicalDamage] [bit] NULL,
	[LocationAndRouteIsAsPerDesignDwg] [bit] NULL,
	[NoSharpEdge] [bit] NULL,
	[TouchUpPaintingForEndCutsAndInstallingPlasticBushing] [bit] NULL,
	[PropperDistanceFromElect.CableLasdder.HotSurfacesReactors] [bit] NULL,
	[SizeIsCorrectAndTypeAsPerDesignDwgs] [bit] NULL,
	[SupportingIsSatisfactory] [bit] NULL,
 CONSTRAINT [PK_CF849] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [QCElectrical].[CFItem]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [QCElectrical].[CFItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[CFTypeId] [int] NOT NULL,
	[Order] [int] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_CFItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [QCElectrical].[CFType]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [QCElectrical].[CFType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[Description] [nvarchar](255) NULL,
 CONSTRAINT [PK_CFType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [SecAcl].[SourceTable]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [SecAcl].[SourceTable](
	[Id] [int] NULL,
	[Name] [varchar](max) NULL,
	[Allow] [bit] NULL,
	[Value] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [SecAcl].[TestValue]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [SecAcl].[TestValue](
	[Name] [varchar](max) NOT NULL,
	[Value] [varchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [TICKET].[ftAttachmentTicket]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ARITHABORT ON
GO
CREATE TABLE [TICKET].[ftAttachmentTicket] AS FILETABLE ON [PRIMARY] FILESTREAM_ON [TKDocumentStore]
WITH
(
FILETABLE_DIRECTORY = N'TKDocumentStore', FILETABLE_COLLATE_FILENAME = Arabic_CI_AS
)

GO
/****** Object:  Table [TICKET].[Prirority]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TICKET].[Prirority](
	[PrirorityId] [int] IDENTITY(1,1) NOT NULL,
	[Prirority] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Prirority] PRIMARY KEY CLUSTERED 
(
	[PrirorityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [TICKET].[Status]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TICKET].[Status](
	[StatusId] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [TICKET].[Ticket]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TICKET].[Ticket](
	[TicketId] [int] IDENTITY(1,1) NOT NULL,
	[TicketNumber] [varchar](255) NOT NULL,
	[Subject] [nvarchar](255) NOT NULL,
	[BriefDescription] [text] NULL,
	[ProjectId] [int] NOT NULL,
	[CompanyId] [int] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[DisciplineId] [int] NOT NULL,
	[DstDisciplineId] [int] NULL,
	[StatusId] [int] NULL,
	[PrirorityId] [int] NULL,
	[IsDelete] [bit] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdateAt] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[DeletedAt] [datetime] NULL,
	[DeletedBy] [int] NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[TicketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [TICKET].[TicketDetail]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TICKET].[TicketDetail](
	[Id] [int] NOT NULL,
	[TicketId] [int] NULL,
	[UserId] [int] NULL,
	[Comment] [nvarchar](255) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NULL,
	[DeletedAt] [datetime] NULL,
	[UpdatedUserId] [int] NULL,
	[DeletedUserId] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [NonClusteredIndex-20220130-100822]    Script Date: 2/9/2022 5:49:40 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [NonClusteredIndex-20220130-100822] ON [EL].[ItemCode]
(
	[ItemCode] ASC
)
WHERE ([IsDelete]=(0))
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [NonClusteredIndex-20220202-172309]    Script Date: 2/9/2022 5:49:40 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [NonClusteredIndex-20220202-172309] ON [EL].[Packing]
(
	[DocumentId] ASC,
	[UnitId] ASC,
	[ItemCodeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [NonClusteredIndex-20211101-151711]    Script Date: 2/9/2022 5:49:40 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [NonClusteredIndex-20211101-151711] ON [GatePass].[Person]
(
	[NationalCode] ASC,
	[ProjectId] ASC
)
WHERE ([IsDelete]=(0))
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [NonClusteredIndex-20220119-132730]    Script Date: 2/9/2022 5:49:40 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [NonClusteredIndex-20220119-132730] ON [GatePass].[PersonContract]
(
	[PersonId] ASC,
	[ContractId] ASC,
	[PersonCode] ASC
)
WHERE ([Status]=(1))
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [CM].[City] ADD  CONSTRAINT [DF_City_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [CM].[CMAttachments] ADD  CONSTRAINT [DF_CMAttachments_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [CM].[CMAttachments] ADD  CONSTRAINT [DF_CMAttachments_IsUsed]  DEFAULT ((0)) FOR [IsUsed]
GO
ALTER TABLE [CM].[CMReportNumber] ADD  CONSTRAINT [DF_CMReportNo_Counter]  DEFAULT ((0)) FOR [Counter]
GO
ALTER TABLE [CM].[CMSignConfig] ADD  CONSTRAINT [DF_SignConfig_Required]  DEFAULT ((1)) FOR [Required]
GO
ALTER TABLE [CM].[CMSignConfig] ADD  CONSTRAINT [DF_SignConfig_BackRequired]  DEFAULT ((1)) FOR [BackRequired]
GO
ALTER TABLE [CM].[CompanyUnits] ADD  CONSTRAINT [DF_Unit_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [CM].[Countries] ADD  CONSTRAINT [DF_Countries_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [CM].[JobPosition] ADD  CONSTRAINT [DF_JobPosition_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [CM].[Province] ADD  CONSTRAINT [DF_Province_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [EL].[Category] ADD  CONSTRAINT [DF_Category_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [EL].[InventoryBalance] ADD  CONSTRAINT [DF_InventoryBalance_Recieve]  DEFAULT ((0)) FOR [Recieve]
GO
ALTER TABLE [EL].[InventoryBalance] ADD  CONSTRAINT [DF_InventoryBalance_Reserve]  DEFAULT ((0)) FOR [Reserve]
GO
ALTER TABLE [EL].[InventoryBalance] ADD  CONSTRAINT [DF_InventoryBalance_Issue]  DEFAULT ((0)) FOR [Issue]
GO
ALTER TABLE [EL].[InventoryBalance] ADD  CONSTRAINT [DF_InventoryBalance_Return]  DEFAULT ((0)) FOR [Return]
GO
ALTER TABLE [EL].[ItemCode] ADD  CONSTRAINT [DF_ItemCode_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [GatePass].[Attachment] ADD  CONSTRAINT [DF_Attachment_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [GatePass].[FaceIdentificationPlace] ADD  CONSTRAINT [DF_FaceIdentificationPlace_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [GatePass].[GatePass] ADD  CONSTRAINT [DF_GatePass_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [GatePass].[GatePass] ADD  CONSTRAINT [DF_GatePass_IsRevoke]  DEFAULT ((0)) FOR [IsRevoke]
GO
ALTER TABLE [GatePass].[GatePassDetail] ADD  CONSTRAINT [DF_GatePassDetail_Accept]  DEFAULT ((0)) FOR [Accept]
GO
ALTER TABLE [GatePass].[GatePassType] ADD  CONSTRAINT [DF_GatePassType_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [GatePass].[Person] ADD  CONSTRAINT [DF_Employee_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [GatePass].[PersonContract] ADD  CONSTRAINT [DF_PersonContractors_Active]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [GatePass].[PersonFaceIdentification] ADD  CONSTRAINT [DF_EmployeeFaceIdentification_Accept]  DEFAULT ((0)) FOR [Accept]
GO
ALTER TABLE [JobReport].[JobReport] ADD  CONSTRAINT [DF_JobReport_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [JobReport].[JobReport] ADD  CONSTRAINT [DF_JobReport_IsVoid]  DEFAULT ((0)) FOR [IsVoid]
GO
ALTER TABLE [Notify].[NotifyActiveUser] ADD  CONSTRAINT [DF_NotifyActiveUser_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [QCEL].[CFItemsResult] ADD  CONSTRAINT [DF_CFItemsResult_ItemValue]  DEFAULT ((0)) FOR [ItemValue]
GO
ALTER TABLE [QCElectrical].[CFItem] ADD  CONSTRAINT [DF_CFItem_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [TICKET].[Ticket] ADD  CONSTRAINT [DF_Ticket_StatusId]  DEFAULT ((1)) FOR [StatusId]
GO
ALTER TABLE [TICKET].[Ticket] ADD  CONSTRAINT [DF_Ticket_Prirority]  DEFAULT ((0)) FOR [PrirorityId]
GO
ALTER TABLE [TICKET].[Ticket] ADD  CONSTRAINT [DF_Ticket_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [CM].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_Province] FOREIGN KEY([ProvinceId])
REFERENCES [CM].[Province] ([Id])
GO
ALTER TABLE [CM].[City] CHECK CONSTRAINT [FK_City_Province]
GO
ALTER TABLE [CM].[Province]  WITH CHECK ADD  CONSTRAINT [FK_Province_Countries] FOREIGN KEY([CountryId])
REFERENCES [CM].[Countries] ([Id])
GO
ALTER TABLE [CM].[Province] CHECK CONSTRAINT [FK_Province_Countries]
GO
ALTER TABLE [EL].[Packing]  WITH CHECK ADD  CONSTRAINT [FK_Packing_Category] FOREIGN KEY([CategoryId])
REFERENCES [EL].[Category] ([Id])
GO
ALTER TABLE [EL].[Packing] CHECK CONSTRAINT [FK_Packing_Category]
GO
ALTER TABLE [EL].[Packing]  WITH CHECK ADD  CONSTRAINT [FK_Packing_CMDocument] FOREIGN KEY([DocumentId])
REFERENCES [CM].[CMDocument] ([Id])
GO
ALTER TABLE [EL].[Packing] CHECK CONSTRAINT [FK_Packing_CMDocument]
GO
ALTER TABLE [EL].[Packing]  WITH CHECK ADD  CONSTRAINT [FK_Packing_Company1] FOREIGN KEY([VendorId])
REFERENCES [CM].[Company] ([Id])
GO
ALTER TABLE [EL].[Packing] CHECK CONSTRAINT [FK_Packing_Company1]
GO
ALTER TABLE [GatePass].[GatePass]  WITH CHECK ADD  CONSTRAINT [FK_GatePass_CMDocument] FOREIGN KEY([DocumentId])
REFERENCES [CM].[CMDocument] ([Id])
GO
ALTER TABLE [GatePass].[GatePass] CHECK CONSTRAINT [FK_GatePass_CMDocument]
GO
ALTER TABLE [GatePass].[GatePass]  WITH CHECK ADD  CONSTRAINT [FK_GatePass_GatePassType] FOREIGN KEY([GatePassTypeId])
REFERENCES [GatePass].[GatePassType] ([Id])
GO
ALTER TABLE [GatePass].[GatePass] CHECK CONSTRAINT [FK_GatePass_GatePassType]
GO
ALTER TABLE [GatePass].[GatePass]  WITH CHECK ADD  CONSTRAINT [FK_GatePass_JobPosition] FOREIGN KEY([JobPositionId])
REFERENCES [CM].[JobPosition] ([Id])
GO
ALTER TABLE [GatePass].[GatePass] CHECK CONSTRAINT [FK_GatePass_JobPosition]
GO
ALTER TABLE [GatePass].[GatePass]  WITH CHECK ADD  CONSTRAINT [FK_GatePass_OrganizationUnit] FOREIGN KEY([UnitRequestId])
REFERENCES [CM].[OrganizationUnit] ([Id])
GO
ALTER TABLE [GatePass].[GatePass] CHECK CONSTRAINT [FK_GatePass_OrganizationUnit]
GO
ALTER TABLE [GatePass].[GatePass]  WITH CHECK ADD  CONSTRAINT [FK_GatePass_PersonContract] FOREIGN KEY([PersonContractId])
REFERENCES [GatePass].[PersonContract] ([Id])
GO
ALTER TABLE [GatePass].[GatePass] CHECK CONSTRAINT [FK_GatePass_PersonContract]
GO
ALTER TABLE [GatePass].[GatePass]  WITH CHECK ADD  CONSTRAINT [FK_GatePass_User] FOREIGN KEY([CreatedBy])
REFERENCES [CM].[User] ([Id])
GO
ALTER TABLE [GatePass].[GatePass] CHECK CONSTRAINT [FK_GatePass_User]
GO
ALTER TABLE [GatePass].[GatePass]  WITH CHECK ADD  CONSTRAINT [FK_GatePass_User1] FOREIGN KEY([UpdatedBy])
REFERENCES [CM].[User] ([Id])
GO
ALTER TABLE [GatePass].[GatePass] CHECK CONSTRAINT [FK_GatePass_User1]
GO
ALTER TABLE [GatePass].[GatePass]  WITH CHECK ADD  CONSTRAINT [FK_GatePass_User2] FOREIGN KEY([DeletedBy])
REFERENCES [CM].[User] ([Id])
GO
ALTER TABLE [GatePass].[GatePass] CHECK CONSTRAINT [FK_GatePass_User2]
GO
ALTER TABLE [GatePass].[GatePassDetail]  WITH CHECK ADD  CONSTRAINT [FK_GatePassDetail_CMDocument] FOREIGN KEY([DocumentId])
REFERENCES [CM].[CMDocument] ([Id])
GO
ALTER TABLE [GatePass].[GatePassDetail] CHECK CONSTRAINT [FK_GatePassDetail_CMDocument]
GO
ALTER TABLE [GatePass].[GatePassType]  WITH CHECK ADD  CONSTRAINT [FK_GatePassType_GatePassType] FOREIGN KEY([Id])
REFERENCES [GatePass].[GatePassType] ([Id])
GO
ALTER TABLE [GatePass].[GatePassType] CHECK CONSTRAINT [FK_GatePassType_GatePassType]
GO
ALTER TABLE [GatePass].[GatePassType]  WITH CHECK ADD  CONSTRAINT [FK_GatePassType_Project] FOREIGN KEY([ProjectId])
REFERENCES [CM].[Project] ([Id])
GO
ALTER TABLE [GatePass].[GatePassType] CHECK CONSTRAINT [FK_GatePassType_Project]
GO
ALTER TABLE [GatePass].[LetterRequest]  WITH CHECK ADD  CONSTRAINT [FK_LetterRequest_CMDocument] FOREIGN KEY([DocumentId])
REFERENCES [CM].[CMDocument] ([Id])
GO
ALTER TABLE [GatePass].[LetterRequest] CHECK CONSTRAINT [FK_LetterRequest_CMDocument]
GO
ALTER TABLE [GatePass].[LetterRequest]  WITH CHECK ADD  CONSTRAINT [FK_LetterRequest_User] FOREIGN KEY([CreatedBy])
REFERENCES [CM].[User] ([Id])
GO
ALTER TABLE [GatePass].[LetterRequest] CHECK CONSTRAINT [FK_LetterRequest_User]
GO
ALTER TABLE [GatePass].[LetterRequest]  WITH CHECK ADD  CONSTRAINT [FK_LetterRequest_User1] FOREIGN KEY([UpdatedBy])
REFERENCES [CM].[User] ([Id])
GO
ALTER TABLE [GatePass].[LetterRequest] CHECK CONSTRAINT [FK_LetterRequest_User1]
GO
ALTER TABLE [GatePass].[LetterRequest]  WITH CHECK ADD  CONSTRAINT [FK_LetterRequest_User2] FOREIGN KEY([DeletedBy])
REFERENCES [CM].[User] ([Id])
GO
ALTER TABLE [GatePass].[LetterRequest] CHECK CONSTRAINT [FK_LetterRequest_User2]
GO
ALTER TABLE [GatePass].[LetterRequest]  WITH CHECK ADD  CONSTRAINT [FK_SatisfactionLetter_Person] FOREIGN KEY([PersonId])
REFERENCES [GatePass].[Person] ([Id])
GO
ALTER TABLE [GatePass].[LetterRequest] CHECK CONSTRAINT [FK_SatisfactionLetter_Person]
GO
ALTER TABLE [GatePass].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Employee_City] FOREIGN KEY([BirthCityId])
REFERENCES [CM].[City] ([Id])
GO
ALTER TABLE [GatePass].[Person] CHECK CONSTRAINT [FK_Employee_City]
GO
ALTER TABLE [GatePass].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Employee_City1] FOREIGN KEY([CardIssuanceCityId])
REFERENCES [CM].[City] ([Id])
GO
ALTER TABLE [GatePass].[Person] CHECK CONSTRAINT [FK_Employee_City1]
GO
ALTER TABLE [GatePass].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Employee_City2] FOREIGN KEY([FatherBirthCityId])
REFERENCES [CM].[City] ([Id])
GO
ALTER TABLE [GatePass].[Person] CHECK CONSTRAINT [FK_Employee_City2]
GO
ALTER TABLE [GatePass].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Employee_City3] FOREIGN KEY([MotherBirthCityId])
REFERENCES [CM].[City] ([Id])
GO
ALTER TABLE [GatePass].[Person] CHECK CONSTRAINT [FK_Employee_City3]
GO
ALTER TABLE [GatePass].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Project] FOREIGN KEY([ProjectId])
REFERENCES [CM].[Project] ([Id])
GO
ALTER TABLE [GatePass].[Person] CHECK CONSTRAINT [FK_Employee_Project]
GO
ALTER TABLE [GatePass].[PersonContract]  WITH CHECK ADD  CONSTRAINT [FK_PersonContractors_Person] FOREIGN KEY([PersonId])
REFERENCES [GatePass].[Person] ([Id])
GO
ALTER TABLE [GatePass].[PersonContract] CHECK CONSTRAINT [FK_PersonContractors_Person]
GO
ALTER TABLE [GatePass].[PersonFaceIdentification]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeFaceIdentification_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [GatePass].[Person] ([Id])
GO
ALTER TABLE [GatePass].[PersonFaceIdentification] CHECK CONSTRAINT [FK_EmployeeFaceIdentification_Employee]
GO
ALTER TABLE [GatePass].[PersonFaceIdentification]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeFaceIdentification_Employee1] FOREIGN KEY([EmployeeId])
REFERENCES [GatePass].[Person] ([Id])
GO
ALTER TABLE [GatePass].[PersonFaceIdentification] CHECK CONSTRAINT [FK_EmployeeFaceIdentification_Employee1]
GO
ALTER TABLE [JobReport].[JobReport]  WITH CHECK ADD  CONSTRAINT [FK_JobReport_Company] FOREIGN KEY([CompanyId])
REFERENCES [CM].[Company] ([Id])
GO
ALTER TABLE [JobReport].[JobReport] CHECK CONSTRAINT [FK_JobReport_Company]
GO
ALTER TABLE [JobReport].[JobReport]  WITH CHECK ADD  CONSTRAINT [FK_JobReport_Document] FOREIGN KEY([ObjectId])
REFERENCES [CM].[CMDocument] ([Id])
GO
ALTER TABLE [JobReport].[JobReport] CHECK CONSTRAINT [FK_JobReport_Document]
GO
ALTER TABLE [JobReport].[JobReport]  WITH CHECK ADD  CONSTRAINT [FK_JobReport_JobReport] FOREIGN KEY([Id])
REFERENCES [JobReport].[JobReport] ([Id])
GO
ALTER TABLE [JobReport].[JobReport] CHECK CONSTRAINT [FK_JobReport_JobReport]
GO
ALTER TABLE [JobReport].[JobReport]  WITH CHECK ADD  CONSTRAINT [FK_JobReport_JobReport1] FOREIGN KEY([Id])
REFERENCES [JobReport].[JobReport] ([Id])
GO
ALTER TABLE [JobReport].[JobReport] CHECK CONSTRAINT [FK_JobReport_JobReport1]
GO
ALTER TABLE [JobReport].[JobReport]  WITH CHECK ADD  CONSTRAINT [FK_JobReport_OrganizationUnit] FOREIGN KEY([DisciplineId])
REFERENCES [CM].[OrganizationUnit] ([Id])
GO
ALTER TABLE [JobReport].[JobReport] CHECK CONSTRAINT [FK_JobReport_OrganizationUnit]
GO
ALTER TABLE [JobReport].[JobReport]  WITH CHECK ADD  CONSTRAINT [FK_JobReport_Project] FOREIGN KEY([ProjectId])
REFERENCES [CM].[Project] ([Id])
GO
ALTER TABLE [JobReport].[JobReport] CHECK CONSTRAINT [FK_JobReport_Project]
GO
ALTER TABLE [JobReport].[JobReport]  WITH CHECK ADD  CONSTRAINT [FK_JobReport_User] FOREIGN KEY([CreatedBy])
REFERENCES [CM].[User] ([Id])
GO
ALTER TABLE [JobReport].[JobReport] CHECK CONSTRAINT [FK_JobReport_User]
GO
ALTER TABLE [JobReport].[JobReport]  WITH CHECK ADD  CONSTRAINT [FK_JobReport_User1] FOREIGN KEY([UpdatedBy])
REFERENCES [CM].[User] ([Id])
GO
ALTER TABLE [JobReport].[JobReport] CHECK CONSTRAINT [FK_JobReport_User1]
GO
ALTER TABLE [JobReport].[JobReport]  WITH CHECK ADD  CONSTRAINT [FK_JobReport_User2] FOREIGN KEY([DeletedBy])
REFERENCES [CM].[User] ([Id])
GO
ALTER TABLE [JobReport].[JobReport] CHECK CONSTRAINT [FK_JobReport_User2]
GO
ALTER TABLE [QCEL].[CF]  WITH CHECK ADD  CONSTRAINT [FK_CF_CMDocument] FOREIGN KEY([DocumentId])
REFERENCES [CM].[CMDocument] ([Id])
GO
ALTER TABLE [QCEL].[CF] CHECK CONSTRAINT [FK_CF_CMDocument]
GO
ALTER TABLE [TICKET].[Status]  WITH CHECK ADD  CONSTRAINT [FK_Status_Status] FOREIGN KEY([StatusId])
REFERENCES [TICKET].[Status] ([StatusId])
GO
ALTER TABLE [TICKET].[Status] CHECK CONSTRAINT [FK_Status_Status]
GO
ALTER TABLE [TICKET].[TicketDetail]  WITH CHECK ADD  CONSTRAINT [FK_TicketDetail_Ticket] FOREIGN KEY([TicketId])
REFERENCES [TICKET].[Ticket] ([TicketId])
GO
ALTER TABLE [TICKET].[TicketDetail] CHECK CONSTRAINT [FK_TicketDetail_Ticket]
GO
ALTER TABLE [EL].[InventoryBalance]  WITH NOCHECK ADD  CONSTRAINT [CK_InventoryBalance] CHECK  (([Reserve]<=[Inventory]))
GO
ALTER TABLE [EL].[InventoryBalance] CHECK CONSTRAINT [CK_InventoryBalance]
GO
/****** Object:  StoredProcedure [CM].[CheckACL]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script for SelectTopNRows command from SSMS  ******/
--==========================================================
-- Copy Right 2021 - CMIS TEAMS
--==========================================================
CREATE procedure [CM].[CheckACL]
@ProjectId as int,
@UserId as int,
@AclName as varchar(50),
@Allow as int output
As
Begin

	DECLARE @UserAllow AS INT
	DECLARE @GroupAllow As INT

	----- در این قسمت دسترسی مربوط به کاربر بررسی میشود	
	SELECT @UserAllow = Allow
	FROM [CMIS].[CM].[CMAcl] acl
	where [ProjectId]= @ProjectId and UserId = @UserId and [Name]= @AclName

	----- در این قسمت دسترسی مربوط به گروه بررسی میشود
	select TOP 1 @GroupAllow = Allow
	from CM.CMAcl acl
	join CM.UsersGroups ugs on ugs.GroupId = acl.GroupId
	where acl.[ProjectId]=@ProjectId  and ugs.UserId = @UserId and acl.[Name]= @AclName
	ORder BY acl.Allow Desc

	IF @UserAllow IS NULL
		SET @Allow = @GroupAllow
	ELSE 
		SET @Allow = @UserAllow
End
GO
/****** Object:  StoredProcedure [CM].[CleanReseed]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[CleanReseed] 
@TableName As varchar(50)
AS
BEGIN
	DECLARE @query varchar(500)
	SET @query = 'DELETE FROM '+@TableName

	EXEC(@query)

	DBCC CHECKIDENT (@TableName,RESEED, 0)
END

GO
/****** Object:  StoredProcedure [CM].[CreateDocument]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [CM].[CreateDocument]

@ProjectId int,
@ReportNo varchar(255),
@CreatedBy int,
@CompanyId int,
@Type varchar(50),
@DisciplineId int = null,
@Type2 varchar(50) = null,
@Remark nvarchar(300) = null,
@Identity as int output,
@UnitId int = null,
@ContractId int = null,
@ContractorId int = null,
@UId int = null,
@DCCStatus varchar(40) = null,
@DCCStatusChangeDate datetime = null,
@DCCStatusChangeUser INT = null,
@DCCRemark nvarchar(300)= null,
@VoidedBy INT = NULL,
@VoidedDate INT = NULL,
@RevNo varchar(10) = null,
@DCCNextRole varchar(50) = null,
@DCCNextRoleExpireDate datetime = null,
@DCCLastSignDate datetime = null

As
Begin
	Begin Transaction;
	Begin Try

		DECLARE @Now DATETIME = GETDATE();
	
		Insert
		Into CM.CMDocument
		(
			[ProjectId],[ReportNo],[CreatedBy],[Posted],[CreateDate],[Complete],[Accepted],[CompanyId],
			[Type],[Type2],[DisciplineId],[UnitId],[ContractId],[ContractorId],[UId],[DccStatus],[DCCStatusChangeDate],[DCCStatusChangeUser],[DCCRemark],[VoidedBy],[VoidedOn],[RevNo],[DCCNextRole],[DCCNextRoleExpireDate],[DCCLastSignDate],[Remark],[Approved],[IsDelete],[IsVoid]
		)
		Values(					  @ProjectId,@ReportNo,@CreatedBy,0,@Now,0,0,@CompanyId,@Type,@Type2,@DisciplineId,@UnitId,@ContractId,@ContractorId,@UId,@DCCStatus,@DCCStatusChangeDate,@DCCStatusChangeUser,@DCCRemark,@VoidedBy,@VoidedDate,@RevNo,@DCCNextRole,@DCCNextRoleExpireDate,@DCCLastSignDate,@Remark,0,0,0
		)
		
		SET @Identity = SCOPE_IDENTITY();
						
		Commit;
	End Try
	Begin Catch
		RollBack;
	End Catch
End

GO
/****** Object:  StoredProcedure [CM].[CreateFamily]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [CM].[CreateFamily]
@Family nvarchar(50)
AS
BEGIN
	DECLARE @a int = 0;
	DECLARE @b int = 1;
	DECLARE @c int;
	SET @c = @b / @a; 

	INSERT INTO CM.[Family]([Family]) VALUES(@Family)
END
GO
/****** Object:  StoredProcedure [CM].[CreateName]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [CM].[CreateName]
@Name nvarchar(50)
AS
BEGIN
	INSERT INTO CM.[Name]([Name]) VALUES(@Name)
END
GO
/****** Object:  StoredProcedure [CM].[DeleteCities]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[DeleteCities]
@Ids CM.IdsTable ReadOnly,
@UserId int
AS
BEGIN

	BEGIN TRY
		BEGIN TRAN

		UPDATE CM.City SET
			IsDelete = 1,
			DeletedBy = @UserId,
			[DeletedDate] = GETDATE()
		WHERE Id IN (SELECT * FROM @Ids)

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACk;
		THROW
	END CATCH


END

GO
/****** Object:  StoredProcedure [CM].[DeleteCountries]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[DeleteCountries]
@Ids CM.IdsTable ReadOnly,
@UserId int
AS
BEGIN

	BEGIN TRY
		BEGIN TRAN

		UPDATE CM.Countries SET
			IsDelete = 1,
			DeletedBy = @UserId,
			[DeletedDate] = GETDATE()
		WHERE Id IN (SELECT * FROM @Ids)

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACk;
		THROW
	END CATCH


END

GO
/****** Object:  StoredProcedure [CM].[DeleteJobPosition]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[DeleteJobPosition]
@ProjectId int,
@Ids CM.IdsTable ReadOnly,
@UserId int
AS
BEGIN

	BEGIN TRY
		BEGIN TRAN

		--DECLARE @HasAccess int
		--SET @HasAccess = SGN.FnUserHasAcl(@ProjectId ,@UserId,'GatePass.DeleteJobPosition')

		--IF @HasAccess IS NULL OR @HasAccess = 0
		--	THROW 50002,'you don''t have access for delete opration on this form!',1


		UPDATE CM.JobPosition SET
			IsDelete = 1,
			DeletedBy = @UserId,
			[DeletedDate] = GETDATE()
		WHERE Id IN (SELECT * FROM @Ids)


		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACk;
		THROW
	END CATCH


END

GO
/****** Object:  StoredProcedure [CM].[DeleteProvinces]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[DeleteProvinces]
@Ids CM.IdsTable ReadOnly,
@UserId int
AS
BEGIN

	BEGIN TRY
		BEGIN TRAN

		UPDATE CM.Province SET
			IsDelete = 1,
			DeletedBy = @UserId,
			[DeletedDate] = GETDATE()
		WHERE Id IN (SELECT * FROM @Ids)

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACk;
		THROW
	END CATCH


END

GO
/****** Object:  StoredProcedure [CM].[FetchAccessDiscipline]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==========================================================
-- Copy Right 2021 - CMIS TEAMS
--==========================================================
CREATE PROCEDURE [CM].[FetchAccessDiscipline]
@ProjectId as int,
@UserId as int,
@Acl as varchar(50)
AS
BEGIN

	select ou.Id,ou.Symbol, ou.[Name] from CM.CMAclItem acli
	inner join CM.CMAcl acl on acl.Id = acli.AclId
	inner join CM.OrganizationUnit ou on ou.Id = acli.[Value]
	where acl.ProjectId =@ProjectId and acl.UserId= @UserId and acl.[Name]=@Acl and acl.Allow=1
	UNION
	select ou.Id,ou.Symbol, ou.[Name] from CM.CMAclItem acli
	inner join CM.CMAcl acl on acl.Id = acli.AclId
	inner join CM.UsersGroups ugs on ugs.GroupId = acl.GroupId
	inner join CM.OrganizationUnit ou on ou.Id = acli.[Value]
	where acl.ProjectId =@ProjectId and ugs.UserId= @UserId and acl.[Name]=@Acl and acl.Allow=1
	order by ou.Id
END



GO
/****** Object:  StoredProcedure [CM].[FetchAllUsersAccessDiscipline]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [CM].[FetchAllUsersAccessDiscipline]
@ProjectId as int,
@Acl as varchar(50)
AS
BEGIN

	select ou.Id,ou.Symbol, ou.[Name],acl.UserId from CM.CMAclItem acli
	inner join CM.CMAcl acl on acl.Id = acli.AclId
	inner join CM.OrganizationUnit ou on ou.Id = acli.[Value]
	where acl.ProjectId =@ProjectId and acl.[Name]=@Acl and acl.Allow=1
	UNION
	select ou.Id,ou.Symbol, ou.[Name],ugs.UserId from CM.CMAclItem acli
	inner join CM.CMAcl acl on acl.Id = acli.AclId
	inner join CM.UsersGroups ugs on ugs.GroupId = acl.GroupId
	inner join CM.OrganizationUnit ou on ou.Id = acli.[Value]
	where acl.ProjectId =@ProjectId and acl.[Name]=@Acl and acl.Allow=1
	order by ou.Id
END
GO
/****** Object:  StoredProcedure [CM].[FetchAreaUnitCombo]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[FetchAreaUnitCombo]
@ProjectId int
AS
BEGIN
	SELECT un.Id,ar.Id AS AreaId,ar.Name AS AreaName,un.Name AS UnitName,un.Abbreviation AS UnitAbbrivation,CONCAT(ar.[Name],'==>',un.[Name]) AS [FullName] FROM CM.Area ar 
	JOIN CM.Unit un ON un.AreaId = ar.Id 
	WHERE ar.ProjectId = 1
END

GO
/****** Object:  StoredProcedure [CM].[FetchAttachments]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		CMIS TEAM
-- Create date: 2020-04-04
-- Description:	
-- =============================================
CREATE PROCEDURE [CM].[FetchAttachments]
@ProjectId as int,
@ObjectName as nvarchar(255),
@ObjectId as int,
@FileTableName varchar(55)

AS
BEGIN

	DROP TABLE IF EXISTS  #AttachmentTemp

	SELECT [Id],[FileName],CustomType,Remark,CreatedUserId,CreatedDate,stream_id INTO #AttachmentTemp
		FROM CM.CMAttachments
		WHERE ProjectId = @ProjectId and ObjectName = @ObjectName and ObjectId = @ObjectId and IsDelete = 0

	Declare @query as varchar(MAX) = ''
	Set @query ='SELECT att.Id As Id,att.[FileName],att.CustomType,att.Remark,u.[FullName] As [User],att.CreatedDate,'''' As FilePath, ''' + @FileTableName + ''' As FileTableName
		FROM #AttachmentTemp att
			join ' + @FileTableName +' ftAtt on ftAtt.stream_id = att.stream_id
			join CM.[User] u ON u.Id = att.CreatedUserId'


	exec(@query)
END

GO
/****** Object:  StoredProcedure [CM].[FetchAvatarByUserId]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[FetchAvatarByUserId]
@Id int,
@Avatar varbinary(MAX) output
AS
BEGIN
	SELECT @Avatar = ProfileImage FROM CM.[User] WHERE Id = @Id
END

GO
/****** Object:  StoredProcedure [CM].[FetchCities]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[FetchCities]
@ProvinceId int = NULL
AS
BEGIN
	IF @ProvinceId IS NULL
		SELECT c.Id, c.ProvinceId, c.[Name], c.EnName,prv.[Name] Province,prv.EnName EnProvince,c.NationalCode,u.FullName AS CreatedBy, c.CreatedDate FROM CM.City c
		JOIN CM.Province prv ON prv.Id =  c.ProvinceId
		JOIN CM.[User] u On u.Id = c.CreatedBy
		WHERE c.IsDelete = 0 ORDER BY prv.[Name] ,c.[Name]

	ELSE
		SELECT c.Id, c.ProvinceId, c.[Name], c.EnName,prv.[Name] Province,prv.EnName EnProvince,c.NationalCode,u.FullName AS CreatedBy, c.CreatedDate FROM CM.City c
		JOIN CM.Province prv ON prv.Id =  c.ProvinceId
		JOIN CM.[User] u On u.Id = c.CreatedBy
		 WHERE ProvinceId = @ProvinceId AND c.IsDelete = 0 ORDER BY prv.[Name] ,c.[Name]
END

GO
/****** Object:  StoredProcedure [CM].[FetchCompanies]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[FetchCompanies]
@ProjectId int,
@UserId int,
@AclName varchar(55)
AS
BEGIN

	SELECT acl.Id As AclId,acli.Id As AclItemId,acli.[Value],co.FullName FROM CM.CMAcl acl
	JOIN CM.CMAclItem acli On acli.AclId = acl.Id
	JOIN CM.Company co ON co.Id = acli.[Value]
	WHERE acl.ProjectId = @ProjectId AND acl.UserId = @UserId AND acl.[Name] = @AclName
END

GO
/****** Object:  StoredProcedure [CM].[FetchCompaniesCombo]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[FetchCompaniesCombo] 
@ProjectId as int,
@UserId as int,
@Acl as varchar(50)
AS
BEGIN
	select co.Id,co.Symbol,co.FullName AS [FullName] from CM.CMAclItem acli
		join CM.CMAcl acl on acl.Id = acli.AclId
		join CM.[Company] co on co.Id = acli.[Value]
		where acl.ProjectId =@ProjectId and acl.UserId= @UserId and acl.[Name]=@Acl and acl.Allow=1
	UNION
	select co.Id,co.Symbol,co.FullName AS [FullName] from CM.CMAclItem acli
		inner join CM.CMAcl acl on acl.Id = acli.AclId
		inner join CM.UsersGroups ugs on ugs.GroupId = acl.GroupId
		inner join CM.[Company] co on co.Id = acli.[Value]
		where acl.ProjectId =@ProjectId and ugs.UserId= @UserId and acl.[Name]=@Acl and acl.Allow=1
		order by co.Id
END



GO
/****** Object:  StoredProcedure [CM].[FetchConfig]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[FetchConfig]
@ProjectId int,
@Scope varchar(50)
AS
BEGIN
	SELECT * FROM CM.Config WHERE ProjectId = @ProjectId AND Scope = @Scope
END

GO
/****** Object:  StoredProcedure [CM].[FetchContractsCombo]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[FetchContractsCombo] 
@ProjectId as int,
@UserId as int,
@Acl as varchar(50)
AS
BEGIN
	select cont.Id,emp.Id As EmployerId,contractor.Id As ContractorId,contractor.Symbol AS ContractorSymbol,emp.Symbol AS EmployerSymbol,contractor.FullName AS Contractor,emp.FullName AS Employer,CONCAT(emp.Symbol,' => ',contractor.FullName) AS [Contract] from CM.CMAclItem acli
		inner join CM.CMAcl acl on acl.Id = acli.AclId
		inner join CM.[Contract] cont on cont.Id = acli.[Value]
		inner join CM.[Company] emp on emp.Id = cont.EmployerId
		inner join CM.[Company] contractor on contractor.Id = cont.ContractorId
		where acl.ProjectId =@ProjectId and acl.UserId= @UserId and acl.[Name]=@Acl and acl.Allow=1
	UNION
	select cont.Id,emp.Id As EmployerId,contractor.Id As ContractorId,contractor.Symbol AS ContractorSymbol,emp.Symbol AS EmployerSymbol,contractor.FullName AS Contractor,emp.FullName AS Employer, CONCAT(emp.Symbol,' => ',contractor.FullName) AS [Name] from CM.CMAclItem acli
		inner join CM.CMAcl acl on acl.Id = acli.AclId
		inner join CM.UsersGroups ugs on ugs.GroupId = acl.GroupId
		inner join CM.[Contract] cont on cont.Id = acli.[Value]
		inner join CM.[Company] emp on emp.Id = cont.EmployerId
		inner join CM.[Company] contractor on contractor.Id = cont.ContractorId
		where acl.ProjectId =@ProjectId and ugs.UserId= @UserId and acl.[Name]=@Acl and acl.Allow=1
		order by cont.Id
END



GO
/****** Object:  StoredProcedure [CM].[FetchCountries]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[FetchCountries]

AS
BEGIN
	SELECT cont.[Id],cont.[Name],cont.[EnName],u.[FullName] CreateBy,cont.[CreatedDate] FROM CM.Countries cont
	JOIN CM.[User] u ON u.Id = cont.CreatedBy
	WHERE cont.IsDelete = 0
	ORDER BY cont.[Name]

END

GO
/****** Object:  StoredProcedure [CM].[FetchDisciplineCombo]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[FetchDisciplineCombo]
@ProjectId as int,
@All as bit
AS
BEGIN
	Select [Id],[Symbol],[Name] from CM.OrganizationUnit where ProjectId = @ProjectId and (IsDiscipline=1 OR @All = 1)
END

GO
/****** Object:  StoredProcedure [CM].[FetchDocumentById]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [CM].[FetchDocumentById]
@DocumentId as int
AS
BEGIN
	Select * from [CM].[CMDocument] where Id = @DocumentId
END

GO
/****** Object:  StoredProcedure [CM].[FetchDWGNo]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [CM].[FetchDWGNo]

AS
BEGIN
	SELECT RevisionId, [DWG No.] AS DWGNo, RevNo, TagNo FROM CMIS_DEVELOPER.DCC.VQCEL_PlanRevisionNo
END


GO
/****** Object:  StoredProcedure [CM].[FetchFileStream]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[FetchFileStream]
@FileTableName varchar(255),
@AttachmentId int
AS
BEGIN

	Declare @streame_id uniqueidentifier
	
	SELECT @streame_id = stream_id  FROM CM.CMAttachments
		Where Id = @AttachmentId
	
	Declare @FileTableDaynamicQuery as varchar(MAX) = ''
	Set @FileTableDaynamicQuery ='SELECT [file_stream],[name] FROM ' + @FileTableName + ' WHERE [stream_id]= '''+ CONVERT(varchar(max),@streame_id)+''''

	exec(@FileTableDaynamicQuery)

END

GO
/****** Object:  StoredProcedure [CM].[FetchGroupById]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [CM].[FetchGroupById]
@GroupId as int
AS
BEGIN
 Select * from CM.[UserGroup] where Id = @GroupId
END

GO
/****** Object:  StoredProcedure [CM].[FetchJobPosition]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[FetchJobPosition]
@ProjectId int
AS
BEGIN

	SELECT jp.[Id],jp.ProjectId,jp.[Name],jp.EnName,CM.FnProjectName(jp.ProjectId) Project,u1.FullName CreatedBy,jp.CreatedDate FROM CM.JobPosition jp
	JOIN CM.[User] u1 ON u1.Id = jp.CreatedBy
	WHERE jp.ProjectId = @ProjectId AND jp.IsDelete = 0
	ORDER BY jp.CreatedDate DESC


END

GO
/****** Object:  StoredProcedure [CM].[FetchPermissions]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[FetchPermissions] 
@ProjectId INT,
@UserId INT
AS
BEGIN
	WITH PermisionCTE AS (
		SELECT acl.Name, acl.Allow,0 AS IsGroup  FROM CM.CMAcl acl
		WHERE acl.UserId = @UserId AND acl.ProjectId = @ProjectId

		UNION

		SELECT acl.Name,acl.Allow,1 AS IsGroup FROM CM.CMAcl acl
		JOIN CM.UsersGroups usgs ON usgs.GroupId = acl.GroupId AND usgs.UserId = @UserId
		WHERE acl.ProjectId = @ProjectId
	) SELECT PermisionCTE.Name, PermisionCTE.Allow, PermisionCTE.IsGroup FROM PermisionCTE
END

GO
/****** Object:  StoredProcedure [CM].[FetchProjectById]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [CM].[FetchProjectById]
@Id as int
AS
BEGIN
	Select * From CM.Project where CM.Project.Id = @Id
END

GO
/****** Object:  StoredProcedure [CM].[FetchProvinces]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[FetchProvinces]
@CountryId int = NULL
AS
BEGIN
	IF @CountryId IS NULL
		SELECT prv.Id,prv.CountryId,prv.Name,prv.EnName,cont.Name As Country,u.FullName As CreatedBy,prv.CreatedDate FROM CM.Province prv
		JOIN CM.Countries cont ON cont.Id = prv.CountryId
		JOIN CM.[User] u ON u.Id = prv.CreatedBy 
		WHERE prv.IsDelete = 0 
		ORDER BY cont.Name,prv.Name

	ELSE
		SELECT prv.Id,prv.CountryId,prv.Name,prv.EnName,cont.Name As Country,u.FullName As CreatedBy,prv.CreatedDate FROM CM.Province prv
		JOIN CM.Countries cont ON cont.Id = prv.CountryId
		JOIN CM.[User] u ON u.Id = prv.CreatedBy WHERE CountryId = @CountryId AND prv.IsDelete = 0 
		ORDER BY cont.Name,prv.Name
END

GO
/****** Object:  StoredProcedure [CM].[FetchServerDateTime]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [CM].[FetchServerDateTime]
@DateWithTime bit = 0,
@ServerDateTime datetime output
AS
BEGIN
	IF @DateWithTime = 0
		SET @ServerDateTime = CONVERT(date,GETDATE(),102)
	ELSE
		SET @ServerDateTime = GETDATE()
END

GO
/****** Object:  StoredProcedure [CM].[FetchUserById]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [CM].[FetchUserById]
@UserId as int
AS
BEGIN
 Select * from CM.[User] where Id = @UserId
END

GO
/****** Object:  StoredProcedure [CM].[FetchUserPermisions]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [CM].[FetchUserPermisions]
@ProjectId int,
@UserId int
AS
BEGIN

	SELECT aclResult.Name,aclResult.Allow FROM (
		 SELECT 
			ROW_NUMBER() Over(
					Partition By Name
					Order By acls.Level ASC, Allow DESC
					) RowNumber, acls.Id, acls.Name, acls.Allow
				
		FROM (
			SELECT 0 AS [Level],Id, Name, Value, Allow, GroupId, UserId, Description, ProjectId FROM CM.CMAcl WHERE UserId = @UserId AND ProjectId = @ProjectId
			UNION
			SELECT 1 AS [Level],acl.Id, acl.Name, acl.Value, acl.Allow, acl.GroupId, acl.UserId, acl.Description, acl.ProjectId FROM CM.CMAcl acl
			INNER JOIN CM.UsersGroups ugs ON ugs.GroupId = acl.GroupId AND ugs.UserId  = @UserId AND acl.ProjectId = @ProjectId
		) acls 
		WHERE acls.Allow IS NOT NULL
	) aclResult WHERE aclResult.RowNumber= 1 ORDER BY aclResult.Name

END

	

GO
/****** Object:  StoredProcedure [CM].[FetchUsers]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[FetchUsers]

AS
BEGIN
	SELECT [Id],[UserName] FROM CM.[User]
END

GO
/****** Object:  StoredProcedure [CM].[GenerateReportNumber]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [CM].[GenerateReportNumber]
@ProjectId int,
@DisciplineId int = NULL,
@EmployerId int = NULL,
@CompanyId int = NULL,
@ObjectName varchar(55),
@Parameters varchar(250) = NULL,
@CounterId int output,
@ReportNumber varchar(MAX) output
AS
BEGIN

	-- Get ReportFarmat
	DECLARE @ReportFormat varchar(150)
	DECLARE @FormatId int
	DECLARE @Digits int
	
	Select @ReportFormat = [Format],@FormatId = Id ,@Digits = Digits From CM.CMReportSyntax 
				WHERE (ProjectId = @ProjectId AND (DisciplineId = @DisciplineId OR (DisciplineId IS NULL AND @DisciplineId IS NULL)) AND ObjectName = @ObjectName AND (EmployerId = @EmployerId OR (EmployerId IS NULL AND @EmployerId IS NULL)))


	BEGIN TRY
		If @ReportFormat IS NOT NULL
			BEGIN
				--Generate Parameters Dynamic Value
				DECLARE @ParamsTableTemp TABLE([Key] varchar(50),[Value] varchar(50)) 
				DECLARE @ReportFormatTempTable TABLE([KeyOrigin] varchar(50),[Key] varchar(50),[Value] varchar(50)) 
				DECLARE @ResultReportFormatTable TABLE([KeyOrigin] varchar(50),[Key] varchar(50),[Value] varchar(50)) 


				DECLARE @ParamsTemp TABLE([Key] int,[Value] VARCHAR(50))

				IF @Parameters <> '' AND @Parameters IS NOT NULL
					BEGIN
						;WITH cteSeperatedParams AS 	
						(SELECT value As [Params] FROM string_split(@Parameters,'#'))

						INSERT INTO @ParamsTableTemp
						Select Substring( [Params], 1,Charindex(',',  [Params])-1) as [Key],
						Substring( [Params], Charindex(',',  [Params])+1, LEN( [Params])) as  [Value]
						from cteSeperatedParams	

					END			

				

				-- DECLARE Report Column
				DECLARE @ReportFormatColumn VARCHAR(150)
				SET @ReportFormatColumn = @ReportFormat
				SET @ReportFormatColumn = REPLACE(@ReportFormatColumn,'{','')
				SET @ReportFormatColumn = REPLACE(@ReportFormatColumn,'}','')
				SET @ReportFormatColumn = REPLACE(@ReportFormatColumn,'[','')
				SET @ReportFormatColumn = REPLACE(@ReportFormatColumn,']','')


				-- Declare ProjectCode
				DECLARE @ProjectCode varchar(20)
				SELECT @ProjectCode = Code FROM CM.Project WHERE Id = @ProjectId

				-- Declare DisciplineSymbol
				DECLARE @DisciplineSymbol varchar(20)
				SELECT @DisciplineSymbol = Symbol FROM CM.OrganizationUnit WHERE Id = @DisciplineId

				-- Declare EmployerSymbol
				DECLARE @EmployerSymbol varchar(20)
				SELECT @EmployerSymbol = Symbol FROM CM.Company WHERE Id = @EmployerId

				-- Declare CompanySymbol
				DECLARE @CompanySymbol varchar(20)
				SELECT @CompanySymbol = Symbol FROM CM.Company WHERE Id = @CompanyId

				INSERT INTO @ReportFormatTempTable
				SELECT value As [KeyOrigin],REPLACE(REPLACE(REPLACE(REPLACE(value,'{',''),'}',''),'[',''),']','') AS [Key],NULL as [Value] FROM string_split(@ReportFormat,'-')


					INSERT INTO @ResultReportFormatTable 
					SELECT rftt.KeyOrigin,rftt.[Key],CASE
				WHEN rftt.[Key] = 'ProjectCode' AND @ProjectCode IS NOT NULL  THEN @ProjectCode
				WHEN rftt.[Key] = 'EmployerSymbol' AND @EmployerSymbol IS NOT NULL  THEN @EmployerSymbol
				WHEN rftt.[Key] = 'CompanySymbol' AND @CompanySymbol IS NOT NULL  THEN @CompanySymbol
				WHEN rftt.[Key] = 'DisciplineSymbol' AND @DisciplineSymbol IS NOT NULL  THEN @DisciplineSymbol
				WHEN PATINDEX('%}%',rftt.[KeyOrigin]) = 0 THEN  rftt.[Key]
				ELSE
					ptt.[Value]
		 
				END AS [Value]
	
				FROM @ReportFormatTempTable rftt
			    LEFT JOIN @ParamsTableTemp ptt on ptt.[Key] = rftt.[KeyOrigin]
				
				SELECT * FROM @ParamsTableTemp
				SELECT * FROM @ReportFormatTempTable
				SELECT * FROM @ResultReportFormatTable 

				DECLARE @NullValue VARCHAR(8000) 
				SELECT @NullValue = COALESCE(@NullValue + ',', '') + 
					ISNULL([KeyOrigin], '')
				FROM @ResultReportFormatTable  WHERE [Value] IS NULL

				IF @NullValue IS NOT NULL 
					BEGIN
						DECLARE @Err Varchar(MAX)
						SET @Err = 'Invalid set parameter ['+@NullValue+']!';
						THROW 50000,@Err,5
					END

				--SELECT REPLACE(KeyOrigin,[Key],[Value]) As ReportFormat FROM #ResultReportFormatTable

				DECLARE @FormatValue VARCHAR(8000) 
				SELECT @FormatValue = COALESCE(@FormatValue + '-', '') + 
					ISNULL(REPLACE(KeyOrigin,[Key],[Value]), '')
				FROM @ResultReportFormatTable


				DECLARE @UniqueValue Varchar(50)
				SET @UniqueValue = CM.FNGetReportNoUniqueValue(@FormatValue)

				--SELECT @UniqueValue
				
				DECLARE @Counter int
				SELECT @Counter = [Counter] FROM CM.CMReportNumber 
				WHERE FormatId = @FormatId AND FormatValue = @FormatValue AND UniqueValue = @UniqueValue

				-- Insert New Report Format Syntax When Not Exist In Report Format Number Table
				IF @Counter IS NULL
					BEGIN
						INSERT INTO CM.CMReportNumber (FormatId,FormatValue,UniqueValue,[Counter])
						Values(@FormatId,@FormatValue,@UniqueValue,0)
																	
						
						SELECT @Counter = [Counter] FROM CM.CMReportNumber 
						WHERE FormatId = @FormatId AND FormatValue = @FormatValue AND UniqueValue = @UniqueValue			
					END

				SELECT @CounterId = Id  FROM CM.CMReportNumber 
				WHERE FormatId = @FormatId AND FormatValue = @FormatValue AND UniqueValue = @UniqueValue

				-- Generate Digit Format 
				DECLARE @i int
				SET @i = 1
				DEClARE @DigitFormat Varchar(50) = ''
				WHILE (@i<=@Digits)
				BEGIN
					SET @DigitFormat = @DigitFormat + '0'
					SET @i = @i+1
				END

				DECLARE @FormatedCounter Varchar(50)
				SET @FormatedCounter = FORMAT(@Counter + 1,@DigitFormat)
				
				SET @ReportNumber = '' + REPLACE(REPLACE(REPLACE(REPLACE(@FormatValue,'{',''),'}',''),'[',''),']','') + '-' + @FormatedCounter	
				
			END		
		ELSE	
			THROW 50001,'Report Number Format Not Found!',5 
			
	END TRY
	BEGIN CATCH
		THROW
	END CATCH
		
END

GO
/****** Object:  StoredProcedure [CM].[GetUserProfileImage]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [CM].[GetUserProfileImage]
@Id int
AS
BEGIN

	SELECT [ProfileImage] FROM CM.[User] WHERE Id = @Id


END

GO
/****** Object:  StoredProcedure [CM].[GetUsers]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[GetUsers]

AS
BEGIN
	SELECT * FROM CM.[User]
END

GO
/****** Object:  StoredProcedure [CM].[IncrementReportNumber]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[IncrementReportNumber]
@CounterId int
AS
BEGIN
	Update CM.CMReportNumber SET
		[Counter] = [Counter] + 1
	WHERE Id = @CounterId
END

GO
/****** Object:  StoredProcedure [CM].[Login]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[Login]
@ProjectId INT,
@UserName VARCHAR(55),
@Password VARCHAR(MAX)
AS
BEGIN
	SELECT Id, CompanyId, UserName, Password, LastPasswordChange, FirstName, LastName, FullName, enFirstName, enLastName, enFullName, LastLoginDate, LastLoginIp, Active, JobTitle, ProfileImage, LoggedIn, LastLogoutDate, MustToChangePassword, SignImage, SignImageTQ, SignName FROM CM.[User] WHERE @ProjectId = @ProjectId AND UserName = @UserName AND [Password] = @Password
END

GO
/****** Object:  StoredProcedure [CM].[NewFetchAttachments]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		CMIS TEAM
-- Create date: 2020-04-04
-- Description:	
-- =============================================
CREATE PROCEDURE [CM].[NewFetchAttachments]
@ProjectId as int,
@ObjectName as nvarchar(255),
@ObjectId as int,
@FileTableName varchar(55)

AS
BEGIN

	DROP TABLE IF EXISTS  #AttachmentTemp

	SELECT [Id],[FileName],CustomType,Remark,IsDelete,IsUsed,CreatedUserId,CreatedDate,stream_id INTO #AttachmentTemp
		FROM CM.CMAttachments
		WHERE ProjectId = @ProjectId and ObjectName = @ObjectName and ObjectId = @ObjectId

	Declare @query as varchar(MAX) = ''
	Set @query ='SELECT att.Id As Id,att.[FileName],att.CustomType,att.Remark,att.IsDelete,att.IsUsed,u.[FullName] As [User],att.CreatedDate,''Show File'' AS ShowFile, ''' + @FileTableName + ''' As FileTableName
		FROM #AttachmentTemp att
			join ' + @FileTableName +' ftAtt on ftAtt.stream_id = att.stream_id
			join CM.[User] u ON u.Id = att.CreatedUserId'


	exec(@query)
END

GO
/****** Object:  StoredProcedure [CM].[Reseed]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [CM].[Reseed] 
@TableName As varchar(50)
AS
BEGIN
	DBCC CHECKIDENT (@TableName,RESEED, 0)
END

GO
/****** Object:  StoredProcedure [CM].[SaveCity]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[SaveCity]
@UserId int,
@ProvinceId int,
@Name nvarchar(50),
@EnName varchar(50)

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		INSERT INTO CM.City
		(
			[ProvinceId],
			[Name],
			[EnName],
			[CreatedBy],
			[CreatedDate]

		)VALUES
		(
			@ProvinceId,
			@Name,
			@EnName,
			@UserId,
			GETDATE()
		)
		COMMIT;
	END TRY
	BEGIN CATCH
		ROLLBACK;
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [CM].[SaveCountry]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[SaveCountry]
@UserId int,
@Name nvarchar(50),
@EnName varchar(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		INSERT INTO CM.Countries
		(
			[Name],
			[EnName],
			[CreatedBy],
			[CreatedDate]

		)VALUES
		(
			@Name,
			@EnName,
			@UserId,
			GETDATE()
		)
		COMMIT;
	END TRY
	BEGIN CATCH
		ROLLBACK;
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [CM].[SaveJobPosition]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[SaveJobPosition]
@ProjectId int,
@UserId int,
@Name NvarChar(100),
@EnName NvarChar(100)
AS
BEGIN
	BEGIN TRY	
		BEGIN TRAN

		--DECLARE @HasAccess int
		--SET @HasAccess = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.SaveJobPosition')

		--IF @HasAccess IS NULL OR @HasAccess = 0
		--	THROW 50002,'you don''t have access for save opration on this form!',1


		INSERT INTO CM.JobPosition 
		(
			ProjectId,
			[Name],
			[EnName],
			CreatedBy,
			CreatedDate
		)VALUES
		(
			@ProjectId,
			@Name,
			@EnName,
			@UserId,
			GETDATE()
		)


		COMMIT;

	END TRY	
	BEGIN CATCH
		ROLLBACk;
		THROW
	END CATCH




END

GO
/****** Object:  StoredProcedure [CM].[SaveProvince]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [CM].[SaveProvince]
@UserId int,
@CountryId int,
@Name nvarchar(50),
@EnName varchar(50)

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		INSERT INTO CM.Province
		(
			[CountryId],
			[Name],
			[EnName],
			[CreatedBy],
			[CreatedDate]

		)VALUES
		(
			@CountryId,
			@Name,
			@EnName,
			@UserId,
			GETDATE()
		)
		COMMIT;
	END TRY
	BEGIN CATCH
		ROLLBACK;
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [CM].[UpdateCity]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [CM].[UpdateCity]
@Id int,
@ProvinceId int,
@UserId int,
@Name nvarchar(50),
@EnName varchar(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		UPDATE CM.City SET
			[ProvinceId] = @ProvinceId,
			[Name] = @Name,
			[EnName] = @EnName,
			[UpdatedBy] = @UserId,
			[UpdatedDate] = GETDATE()
		WHERE Id = @Id

		COMMIT;
	END TRY
	BEGIN CATCH
		ROLLBACK;
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [CM].[UpdateCountry]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [CM].[UpdateCountry]
@Id int,
@UserId int,
@Name nvarchar(50),
@EnName varchar(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		UPDATE CM.Countries SET
			[Name] = @Name,
			[EnName] = @EnName,
			[UpdatedBy] = @UserId,
			[UpdatedDate] = GETDATE()
		WHERE Id = @Id

		COMMIT;
	END TRY
	BEGIN CATCH
		ROLLBACK;
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [CM].[UpdateDocument]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------------
-- Copy Right 2021 - CMIS TEAMS
---------------------------------------------------------------------------------------
CREATE Procedure [CM].[UpdateDocument]
@DocumentId int,
@ProjectId as int,
@CompanyId as int,
@Type as varchar(50),
@DisciplineId as int,
@Type2 as varchar(50),
@Remark as nvarchar(300),
@ModifiedBy int
As
Begin
	Begin Transaction;
	Begin Try
		Update [CM].[CMDocument] Set 
		[ProjectId] = @ProjectId,
		[CompanyId] = @CompanyId,
		[Type] = @Type,
		[DisciplineId] = @DisciplineId,
		[Type2] = @Type2,
		[Remark] = @Remark,
		[ModifiedOn] = GetDate(),
		[ModifiedBy] = @ModifiedBy
		output @DocumentId 
		Commit;
	End Try
	Begin Catch
		RollBack;
	End Catch
End
GO
/****** Object:  StoredProcedure [CM].[UpdateJobPosition]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [CM].[UpdateJobPosition]
@ProjectId int,
@Id int,
@UserId int,
@Name NvarChar(100),
@EnName varchar(100)
AS
BEGIN
	BEGIN TRY	
		BEGIN TRAN

		--DECLARE @HasAccess int
		--SET @HasAccess = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.UpdateJobPosition')

		--IF @HasAccess IS NULL OR @HasAccess = 0
		--	THROW 50002,'you don''t have access for update opration on this form!',1

		UPDATE CM.JobPosition SET
			[Name] = @Name,
			[EnName] = @EnName,
			[UpdatedBy] = @UserId,
			[UpdatedDate] = GETDATE()
		WHERE Id = @Id

		COMMIT;

	END TRY	
	BEGIN CATCH
		ROLLBACk;
		THROW
	END CATCH




END

GO
/****** Object:  StoredProcedure [CM].[UpdateProvince]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [CM].[UpdateProvince]
@Id int,
@CountryId int,
@UserId int,
@Name nvarchar(50),
@EnName varchar(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		UPDATE CM.Province SET
			[CountryId] = @CountryId,
			[Name] = @Name,
			[EnName] = @EnName,
			[UpdatedBy] = @UserId,
			[UpdatedDate] = GETDATE()
		WHERE Id = @Id

		COMMIT;
	END TRY
	BEGIN CATCH
		ROLLBACK;
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[sp_Recover_Dropped_Objects]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Recover_Dropped_Objects]
    @Database_Name NVARCHAR(MAX),
    @Date_From DATETIME,
    @Date_To DATETIME
AS

DECLARE @Compatibility_Level INT

SELECT @Compatibility_Level=dtb.compatibility_level
FROM master.sys.databases AS dtb WHERE dtb.name=@Database_Name

IF ISNULL(@Compatibility_Level,0)<=80
BEGIN
    RAISERROR('The compatibility level should be equal to or greater SQL SERVER 2005 (90)',16,1)
    RETURN
END

Select [Database Name],Convert(varchar(Max),Substring([RowLog Contents 0],33,LEN([RowLog Contents 0]))) as [Script]
from fn_dblog(NULL,NULL)
Where [Operation]='LOP_DELETE_ROWS' And [Context]='LCX_MARK_AS_GHOST'
And [AllocUnitName]='sys.sysobjvalues.clst'
AND [TRANSACTION ID] IN (SELECT DISTINCT [TRANSACTION ID] FROM    sys.fn_dblog(NULL, NULL)
WHERE Context IN ('LCX_NULL') AND Operation in ('LOP_BEGIN_XACT') 
And [Transaction Name]='DROPOBJ'
And  CONVERT(NVARCHAR(11),[Begin Time]) BETWEEN @Date_From AND @Date_To)
And Substring([RowLog Contents 0],33,LEN([RowLog Contents 0]))<>0
GO
/****** Object:  StoredProcedure [EL].[AffectPLQtyOnInvenotryBalance]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [EL].[AffectPLQtyOnInvenotryBalance]
@DocumentId INT,
@UserId INT
AS 
BEGIN

	DECLARE @PackingItems TABLE(rowId INT,DocumentId INT, CompanyId INT, UnitId INT, ItemCodeId INT,PLQty DECIMAL)

	INSERT INTO @PackingItems
	SELECT ROW_NUMBER() OVER(PARTITION BY doc.Id ORDER BY pk.ItemCodeId) AS rowId ,doc.Id AS DocumentId,doc.CompanyId,pk.UnitId,pk.ItemCodeId, PLQty FROM CM.CMDocument doc
	JOIN EL.Packing pk ON pk.DocumentId = doc.Id
	JOIN EL.ItemCode ic ON ic.Id = pk.ItemCodeId
	WHERE doc.Id = @DocumentId

	DECLARE @ItemCount INT;
	SELECT @ItemCount = COUNT(rowId) FROM @PackingItems;

	DECLARE @ItemCounter INT = 1;
	WHILE @ItemCounter <= @ItemCount
	BEGIN
		DECLARE @UnitId INT;
		DECLARE @CompanyId INT;
		DECLARE @ItemCodeId INT;
	
		DECLARE @PLQty DECIMAL;
	
		SELECT @UnitId = UnitId,@CompanyId = CompanyId,@ItemCodeId = ItemCodeId,@PLQty = PLQty FROM @PackingItems WHERE rowId = @ItemCounter	
	
		DECLARE @InvBalanceId INT;
		SELECT @InvBalanceId = Id FROM EL.InventoryBalance WHERE CompanyId = @CompanyId AND UnitId = @UnitId AND ItemCodeId = @ItemCodeId

		IF @InvBalanceId IS NULL
		BEGIN

		INSERT INTO EL.InventoryBalance(CompanyId, UnitId, ItemCodeId, Recieve, CreatedBy, CreatedDate)
		VALUES(
			@CompanyId, -- CompanyId - int
			@UnitId   , -- UnitId - int
			@ItemCodeId   , -- ItemCodeId - int
			@PLQty   , -- Mto - int
			@UserId  , -- Recieve - int
			GETDATE()    -- Reserve - int
		    )

		END
		ELSE
		BEGIN

		UPDATE EL.InventoryBalance SET
		Recieve = Recieve + @PLQty,
		UpdatedDate = GETDATE()
		WHERE Id = @InvBalanceId





		END

		--Incerement row counter
		SET @ItemCounter = @ItemCounter + 1;
	END

END


GO
/****** Object:  StoredProcedure [EL].[DeleteCategory]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [EL].[DeleteCategory]
@Id INT,
@ProjectId INT,
@UserId INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		--if category is used can not delete iot and procedure throw error
		DECLARE @usedCount INT = 0;
		SELECT @usedCount = COUNT(*) FROM EL.ItemCode WHERE CategoryId = @Id

		IF @usedCount > 0 THROW 50001,'Category is used and can not delete it!',1;

		--check save item code acl here
		DECLARE @HasAccess BIT= 0;
		SET @HasAccess = SGN.FnUserHasAcl(@ProjectId,@UserId,'EL.ButtonDeleteCategory')

		IF @HasAccess = 0 THROW 50001,'Unfortantly you don''t have access for delete category',1;
		
		UPDATE EL.Category SET
			IsDelete = 1,
			DeletedBy = @userId,
			DeletedDate = GETDATE()
			WHERE Id = @Id


		COMMIT TRAN
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRAN;
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [EL].[DeleteItemCode]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [EL].[DeleteItemCode]
@Id INT,
@ProjectId INT,
@UserId INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		--Start procedure login

		--check save item code acl here
		DECLARE @HasAccess BIT= 0;
		SET @HasAccess = SGN.FnUserHasAcl(@ProjectId,@UserId,'EL.DeleteItemCode')

		IF @HasAccess = 0 THROW 50001,'Unfortantly you don''t have access for delete item code',1;
		
		UPDATE EL.ItemCode SET
			IsDelete = 1,
			DeletedBy = @userId,
			DeletedDate = GETDATE()
			WHERE Id = @Id


		COMMIT TRAN
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRAN;
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [EL].[GetCategories]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [EL].[GetCategories]
@Id INT = NULL,
@ProjectId INT,
@UserId INT
AS
BEGIN
	BEGIN TRY
		-- if item code id is 0 then data will be insert else data will be update
		IF @Id IS NULL
			BEGIN
			--check save item code acl here
			DECLARE @HasAccess BIT= 0;
			SET @HasAccess = SGN.FnUserHasAcl(@ProjectId,@UserId,'EL.ShowCategoiesList');

			IF @HasAccess = 0 THROW 50001,'Unfortantly you don''t have access for show categories',1;

			SELECT cat.Id, cat.ParentId, cat.Category,cat.IsDelete, cat.CreatedBy, cat.CreatedDate FROM El.Category cat
			JOIN CM.[User] u ON u.Id = cat.CreatedBy

			END
		ELSE
			BEGIN

				SELECT cat.Id, cat.ParentId, cat.Category,IsDelete, cat.CreatedBy, cat.CreatedDate FROM El.Category cat
				JOIN CM.[User] u ON u.Id = cat.CreatedBy WHERE cat.Id = @Id

			END
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [EL].[GetCategoriesCombo]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [EL].[GetCategoriesCombo]
@All BIT = 0
AS
BEGIN
	BEGIN TRY

		SELECT 0 AS Id,NULL AS ParentId,'-' AS Category
		UNION
		SELECT cat.Id, cat.ParentId, cat.Category FROM El.Category cat
		JOIN CM.[User] u ON u.Id = cat.CreatedBy
		WHERE cat.IsDelete = 0 AND (@All = 1 OR cat.ParentId IS NULL )

	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [EL].[GetItemCodes]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [EL].[GetItemCodes]
@Id INT = NULL,
@ProjectId INT,
@UserId INT
AS
BEGIN
	BEGIN TRY
		-- if item code id is 0 then data will be insert else data will be update
		IF @Id IS NULL
		BEGIN
		--check save item code acl here
		DECLARE @HasAccess BIT= 0;
		SET @HasAccess = SGN.FnUserHasAcl(@ProjectId,@UserId,'EL.ShowItemCodeList');

		IF @HasAccess = 0 THROW 50001,'Unfortantly you don''t have access for show item codes',1;

		SELECT ic.Id,ic.CategoryId, ic.WarehouseItemCodeId, ic.ItemCode,cat.Category , ic.CreatedBy, ic.CreatedDate FROM El.ItemCode ic
		LEFT JOIN EL.Category cat ON cat.Id = ic.CategoryId
		JOIN CM.[User] u ON u.Id = ic.CreatedBy
 
		END
		ELSE
		BEGIN

			SELECT ic.Id,ic.CategoryId, ic.WarehouseItemCodeId, ic.ItemCode,cat.Category , ic.CreatedBy, ic.CreatedDate FROM El.ItemCode ic
			LEFT JOIN EL.Category cat ON cat.Id = ic.CategoryId
			JOIN CM.[User] u ON u.Id = ic.CreatedBy WHERE ic.Id = @Id

		END
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [EL].[GetItemCodesCombo]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [EL].[GetItemCodesCombo]
@CategoryId INT NULL = NULL
AS
BEGIN


	IF @CategoryId IS NULL
	BEGIN
	SELECT ic.Id,wi.Id AS WarehouseItemCodeId,ic.ItemCode,wi.ItemCode AS WarehouseItemCode FROM EL.ItemCode ic
	JOIN EL.WarehouseItemCode wi ON wi.Id = ic.WarehouseItemCodeId
	END
	ELSE
	BEGIN
	SELECT ic.Id,wi.Id AS WarehouseItemCodeId,ic.ItemCode,wi.ItemCode AS WarehouseItemCode FROM EL.ItemCode ic
	JOIN EL.WarehouseItemCode wi ON wi.Id = ic.WarehouseItemCodeId
	WHERE ic.CategoryId = @CategoryId
	END
END

GO
/****** Object:  StoredProcedure [EL].[GetPackingDocuments]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [EL].[GetPackingDocuments]
@Id INT = NULL,
@ProjectId INT,
@CompanyId INT
AS
BEGIN

	BEGIN TRY
		-- Procedure for geting Paking list item if you pass id you can get one row of item
		DECLARE @DisciplineId INT;
		SET @DisciplineId  = CAST(CM.FnGetConfigValue(@ProjectId,'EL','DisciplineId') AS int);

		IF @Id IS NOT NULL
			SELECT Id, ProjectId, ReportNo, CreatedBy, Posted, CreateDate, Complete, Accepted, CompanyId, Type, DisciplineId, UnitId, Type2, DocumentOwnersRole, IsDelete FROM CM.CMDocument WHERE CompanyId = @CompanyId AND Type = 'EL.PL' AND Id = @Id AND ProjectId = @ProjectId AND Id = @Id
		ELSE
		BEGIN
			SELECT Id, ProjectId, ReportNo, CreatedBy, Posted, CreateDate, Complete, Accepted, CompanyId, Type, DisciplineId, UnitId, Type2, DocumentOwnersRole, IsDelete FROM CM.CMDocument WHERE CompanyId = @CompanyId AND Type = 'EL.PL' AND ProjectId = @ProjectId
		END

	END TRY
	BEGIN CATCH
		;THROW;
	END CATCH



END

GO
/****** Object:  StoredProcedure [EL].[GetPackingItemsByDocumentId]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [EL].[GetPackingItemsByDocumentId]
@DocumentId INT

AS
BEGIN

	SELECT pak.Id, pak.ItemCodeId,ic.ItemCode, pak.UnitId, pak.VendorId, pak.TagNo, pak.CategoryId, pak.Description, pak.Size, pak.PackingNo, pak.PLQty, pak.QtyUnitId FROM EL.Packing pak
	JOIN EL.ItemCode ic ON ic.Id = pak.ItemCodeId
	WHERE DocumentId = @DocumentId
	

END

GO
/****** Object:  StoredProcedure [EL].[GetPLQtyUnit]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [EL].[GetPLQtyUnit]

AS
BEGIN
	SELECT * FROM EL.PlQtyUnit
END

GO
/****** Object:  StoredProcedure [EL].[GetSubCategoriesCombo]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [EL].[GetSubCategoriesCombo]
@CategoryId INT = 0
AS
BEGIN
	BEGIN TRY

		IF @CategoryId = 0
		BEGIN
			SELECT 0 AS Id,NULL AS ParentId,'-' AS Category
			UNION
			SELECT cat.Id, cat.ParentId, cat.Category FROM El.Category cat
			JOIN CM.[User] u ON u.Id = cat.CreatedBy
			WHERE cat.IsDelete = 0 AND cat.ParentId IS NULL

		END
		ELSE
		BEGIN
			SELECT 0 AS Id,NULL AS ParentId,'-' AS Category
			UNION
			SELECT cat.Id, cat.ParentId, cat.Category FROM El.Category cat
			JOIN CM.[User] u ON u.Id = cat.CreatedBy
			WHERE cat.IsDelete = 0 AND cat.ParentId = @CategoryId
		END
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [EL].[GetWarehouseItemCodesCombo]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [EL].[GetWarehouseItemCodesCombo]

AS
BEGIN

	SELECT 0 AS Id, '-' AS ItemCode
	UNION
	SELECT * FROM EL.WarehouseItemCode

END

GO
/****** Object:  StoredProcedure [EL].[SaveCategory]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROC [EL].[SaveCategory]
@Id INT = NULL OUT,
@ParentCategoryId INT = 0,
@Category NVARCHAR(150),
@ProjectId INT,
@UserId INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		-- if item code id is 0 then data will be insert else data will be update
		IF @Id IS NULL
		BEGIN
		--check save item code acl here
		DECLARE @HasAccess BIT= 0;
		SET @HasAccess = SGN.FnUserHasAcl(@ProjectId,@UserId,'EL.ButtonSaveCategory')

		IF @HasAccess = 0 THROW 50001,'Unfortantly you don''t have access for save category',1;

		INSERT INTO El.Category(ParentId,Category, CreatedBy, CreatedDate)
		VALUES(IIF(@ParentCategoryId = 0,NULL,@ParentCategoryId),@Category,@UserId,GETDATE())


		SET @Id = SCOPE_IDENTITY();
 
		END
		ELSE
		BEGIN

			UPDATE EL.Category SET
				ParentId = IIF(@ParentCategoryId = 0,NULL,@ParentCategoryId) ,
				Category = @category,
				UpdatedBy = @UserId,
				UpdatedDate = GETDATE()
				WHERE Id = @Id

		END

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRAN;
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [EL].[SaveItemCode]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [EL].[SaveItemCode]
@Id INT = NULL OUT,
@CategoryId INT = 0,
@WarehouseItemCodeId INT = 0,
@ItemCode VARCHAR(150),
@ProjectId INT,
@UserId INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		-- if item code id is 0 then data will be insert else data will be update
		IF @Id IS NULL
		BEGIN
		--check save item code acl here
		DECLARE @HasAccess BIT= 0;
		SET @HasAccess = SGN.FnUserHasAcl(@ProjectId,@UserId,'EL.ButtonSaveItemCode')

		IF @HasAccess = 0 THROW 50001,'Unfortantly you don''t have access for save item code',1;

		INSERT INTO El.ItemCode(CategoryId,WarehouseItemCodeId,ItemCode, CreatedBy, CreatedDate)
		VALUES(IIF(@CategoryId=0,NULL,@CategoryId),IIF( @WarehouseItemCodeId=0,NULL, @WarehouseItemCodeId),@ItemCode,@UserId,GETDATE())

		SET @Id = SCOPE_IDENTITY();
 
		END
		ELSE
		BEGIN

			UPDATE EL.ItemCode SET
				CategoryId = IIF(@CategoryId=0,NULL,@CategoryId),
				WarehouseItemCodeId = IIF( @WarehouseItemCodeId=0,NULL, @WarehouseItemCodeId),
				ItemCode = @ItemCode,
				UpdatedBy = @UserId,
				UpdatedDate = GETDATE()
				WHERE Id = @Id

		END

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRAN;
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [EL].[SavePacking]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [EL].[SavePacking]
@ProjectId INT,
@CompanyId INT,
@DocumentId INT = NULL,
@UserId INT,
@ReportNo VARCHAR(200),
@PackingItems EL.TvpPackingItems READONLY
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		--check save item code acl here
		DECLARE @HasAccess BIT= 0;
		SET @HasAccess = SGN.FnUserHasAcl(@ProjectId,@UserId,'EL.ButtonSavePacking')

		IF @HasAccess = 0 THROW 50001,'Unfortantly you don''t have access for save packing',1;
				
		DECLARE @DisciplineId INT;
		SET @DisciplineId = CAST(CM.FnGetConfigValue(@ProjectId,'EL','DisciplineId') AS INT)

		-- Check document is posted and send message don't can update it
		IF @DocumentId IS NOT NULL 
		BEGIN 
		
		DECLARE @Posted BIT = 0 
		SELECT @Posted = Posted FROM CM.CMDocument WHERE Id = @DocumentId

		IF @Posted = 1 THROW 50002,'The document is posted and can not update it!',1;


		UPDATE CM.CMDocument SET
		    @CompanyId=@CompanyId, -- int
		    ModifiedBy = @UserId, -- int
			ModifiedOn = GETDATE() -- datetimr
		
		END
		ELSE
		BEGIN
		--Save pl document here
		DECLARE @Identity INT;
		EXEC CM.CreateDocument
			@ProjectId=@projectId, -- int
		    @ReportNo=@ReportNo, -- varchar(255)
		    @CreatedBy=@UserId, -- int
		    @CompanyId=@CompanyId, -- int
		    @Type='EL.PL', -- varchar(50)
		    @DisciplineId=@DisciplineId, -- int
		    @Type2='PL', -- varchar(50)
		    @Remark=N'', -- nvarchar(300)
		    @UId=@UserId, -- int
		    @Identity=@Identity OUTPUT -- int
	
		SET @DocumentId = @Identity;

		END

		
		-- Merge Packing Items
		-- Merge CF Items Value
		MERGE EL.Packing as t
		USING (
			SELECT * FROM @PackingItems			
		) s 

		ON (t.[Id] = s.[Id] )

		WHEN NOT MATCHED By target THEN
			Insert(DocumentId,ItemCodeId,UnitId,VendorId,TagNo,CategoryId,Description,Size,PackingNo,PLQty,QtyUnitId)
			Values(@DocumentId,s.ItemCodeId,s.UnitId,s.VendorId,s.TagNo,s.CategoryId,s.Description,s.Size,s.PackingNo,s.PLQty,s.QtyUnitId)
		WHEN MATCHED THEN
			UPDATE SET
            ItemCodeId = s.ItemCodeId,
			UnitId = s.UnitId,
			VendorId = s.VendorId,
			TagNo = s.TagNo,
			CategoryId = s.categoryId,
			Description = s.Description,
			Size = s.Size,
			PackingNo = s.PackingNo,
			PLQty = s.PLQty,
			QtyUnitId = s.QtyUnitId
			
		WHEN NOT MATCHED BY SOURCE AND t.DocumentId = @DocumentId THEN
			DELETE;

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRAN;
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [EL].[SignPLDocument]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [EL].[SignPLDocument]
@SignRequestType VARCHAR(20) = 'Post',
@ProjectId INT,
@UserId INT,
@ObjectId INT,
@NextRole VARCHAR(55),
@MachineName NVARCHAR(100),
@ActiveDirectoryName NVARCHAR(100),
@CompanyId INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		--Check User Has Acl For Sign This Document
		DECLARE @HasAccess BIT= 0;
		SET @HasAccess = SGN.FnUserHasAcl(@ProjectId,@UserId,'EL.ButtonPostPLDocument')

		IF @HasAccess = 0 THROW 50001,'Unfortantly you don''t have access for post ( PL ) document',1;

		EXEC SGN.SignDocument
			@SignRequestType=@SignRequestType, -- varchar(55)
			@ProjectId=@ProjectId, -- int
			@UserId=@UserId, -- int
			@ObjectName='EL', -- varchar(50)
			@SignConfigObjectName='EL.PL', -- varchar(55)
			@ObjectId=@ObjectId, -- int
			@Remark = NULL,
			@NextRoleUsersId = NULL,
			@AclCanDynamicRoleName = NULL,
			@LoggedUserId = NULL,
			@NextRole=@NextRole, -- varchar(50)
			@MachineName=@MachineName, -- nvarchar(150)
			@ActiveDirectoryName=@ActiveDirectoryName, -- nvarchar(250)
			@CompanyId=@CompanyId; -- int

		-- Affect pl qty after succeded posted pl document
		EXEC EL.AffectPLQtyOnInvenotryBalance
			@DocumentId = @ObjectId,
			@UserId = @UserId



		COMMIT TRAN;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK
		;THROW;
	END CATCH	
END

GO
/****** Object:  StoredProcedure [GatePass].[AcceptGatePass]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[AcceptGatePass]
@ProjectId  INT,
@UserId  INT,
@ObjectId  INT,
@GatePassId INT,
@AnsResult BIT,
@MobileNo VARCHAR(14) = NULL,
@PhoneNo VARCHAR(20) = NULL,
@Address VARCHAR(200) = NULL,
@Files as CM.FileItemType ReadOnly,
@CompanyId  INT = NULL
AS
BEGIN

	BEGIN TRY
	BEGIN TRAN

	-- Get New Person Code From Config table
	DECLARE @PersonCodeConunter INT= 0;
	SELECT @PersonCodeConunter = [Value] FROM CM.Config WHERE Scope = 'GatePass' AND Name = 'PersonCodeCounter' AND ProjectId = @ProjectId

	DECLARE @ObjectName varchar(55) 
	DECLARE @DocumentRole varchar(55)
	DECLARE @RoleOrder INT
	
	SELECT @ObjectName = [Type],@DocumentRole =  DocumentOwnersRole FROM CM.CMDocument WHERE Id= @ObjectId

	SELECT @RoleOrder = [Order] FROM CM.CMSignConfig 
	WHERE Role = @DocumentRole AND ObjectName = @ObjectName AND ProjectId = @ProjectId AND (CompanyId = @CompanyId OR CompanyId IS NULL)


	-- Accept GatePass
	DECLARE @AlreadyAns INT;
	SELECT @AlreadyAns = COUNT(*) FROM GatePass.GatePassDetail 
	WHERE GatePassId = @GatePassId AND RoleOrder = @RoleOrder

	IF @AlreadyAns  = 0
	BEGIN
		INSERT INTO GatePass.GatePassDetail(DocumentId,GatePassId,RoleOrder,Accept,CreatedBy,CreatedDate)
		Values(@ObjectId,@GatePassId,@RoleOrder,@AnsResult,@UserId,GETDATE())

		IF @RoleOrder = 8
		BEGIN

			-- Set PersonCode IF Don't Have Person Code
			DECLARE @CurrentPersonCode VARCHAR(50);
			DECLARE @PersonContractId INT

			SELECT @CurrentPersonCode = pc.PersonCode,@PersonContractId = pc.Id FROM GatePass.PersonContract pc
			JOIN GatePass.GatePass gp ON gp.PersonContractId = pc.Id
			JOIN CM.CMDocument doc ON doc.Id = gp.DocumentId AND doc.ContractId = pc.ContractId
			WHERE doc.Id = @ObjectId AND gp.Id = @GatePassId

			IF @CurrentPersonCode IS NULL AND @AnsResult = 1 BEGIN 
				UPDATE GatePass.PersonContract SET [Date OfEmployeement] = GETDATE(), PersonCode = @PersonCodeConunter + 1  WHERE Id = @PersonContractId
				UPDATE CM.Config SET [Value] = @PersonCodeConunter + 1 WHERE Scope = 'GatePass' AND Name = 'PersonCodeCounter' AND ProjectId = @ProjectId
			END

			-- Revoke Prevoius GatePass
			DECLARE @NationalCode CHAR(10);
			DECLARE @CurrentGatePassId INT;
			DECLARE @PersonId INT;

			SELECT @NationalCode = p.NationalCode,@PersonId = p.Id FROM GatePass.GatePass gp
			JOIN GatePass.PersonContract pc ON pc.Id = gp.PersonContractId
			JOIN GatePass.Person p ON p.Id = pc.PersonId
			WHERE gp.Id = @GatePassId AND gp.DocumentId = @ObjectId

			IF @NationalCode IS NULL THROW 50002,'National Code not found!',1

			IF @NationalCode IS NOT NULL
			BEGIN
				
				-- Update some field by gatepass Issuer
				UPDATE GatePass.Person SET 
				MobileNo = @MobileNo,
				PhoneNo = @PhoneNo,
				ADDRESS = @Address
				WHERE Id = @PersonId										
					
				--EXEC GatePass.RevokeOldGatePasses
				--@ProjectId = @ProjectId,
				--@UserId = @UserId,
				--@GatePassId = @CurrentGatePassId,
				--@NationalCode = @NationalCode

			END
		END

	END
	ELSE
	BEGIN
			UPDATE GatePass.GatePassDetail SET
				Accept = @AnsResult,
				UpdatedBy = @UserId,
				UpdatedDate = GETDATE()
			WHERE RoleOrder  = @RoleOrder AND DocumentId = @ObjectId AND GatePassId = @GatePassId
	END

	
	exec GatePass.SaveAttachment 
		@ProjectId = @ProjectId,
		@UserId = @UserId,
		@ObjectName = @ObjectName,
		@ObjectId = @PersonContractId,
		@IsUsed = 1,
		@Files=@Files


	
	-- Merge For GatePass.Attachemnt
	MERGE GatePass.Attachment as t
	USING (
			SELECT gp.DocumentId,gp.Id As GatePassId,cmatt.Id AS AttachmentId,cmatt.ObjectId AS PersonContractId FROM CM.CMAttachments cmatt		
			JOIN GatePass.GatePass gp ON gp.PersonContractId = cmatt.ObjectId								
			WHERE cmatt.ProjectId = 1 And cmatt.ObjectName = 'GatePass' And cmatt.IsDelete = 0
	) s 

	ON (t.AttachmentId = s.AttachmentId AND t.[GatePassId] = s.[GatePassId] And t.DocumentId = s.DocumentId  AND t.PersonContractId = s.PersonContractId)

	WHEN NOT MATCHED By target THEN		
		Insert(DocumentId,GatePassId,AttachmentId,PersonContractId,CreatedBy,CreatedDate)
		Values(s.DocumentId,s.GatePassId,s.AttachmentId,s.PersonContractId,@UserId,GETDATE())
	
	WHEN NOT MATCHED BY SOURCE AND t.GatePassId = @GatePassId AND t.PersonContractId = @PersonContractId AND t.DocumentId = @ObjectId THEN
		Update Set
		t.DeletedBy = @UserId,
		t.DeletedDate = GETDATE(),
		t.IsDelete = 1;			
	-- End Merge For GatePass Attachments		


	COMMIT

	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK;
		THROW
	END CATCH

END

GO
/****** Object:  StoredProcedure [GatePass].[ActiveGatePassList]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[ActiveGatePassList]
@ProjectId INT
AS
BEGIN
	;WITH ActiveGatepass AS (

		SELECT  ROW_NUMBER() OVER (PARTITION BY p.NationalCode,doc.Complete,doc.Accepted ORDER BY gp.Id DESC) RowNumber, LEAD(gp.Id) OVER (PARTITION BY p.NationalCode,doc.Complete,doc.Accepted ORDER BY gp.Id DESC) PreviousActiveGatePassId,doc.Id AS DocumentId,gp.Id AS GatePassId,p.Id AS PersonId,pc.Id AS PersonContractId,pc.ContractId,cont.EmployerId,cont.ContractorId,p.NationalCode,DATEADD(DAY,gp.AttendanceDuration, gp.AttendanceDate) AS [ExpireDate],gp.IsRevoke,doc.Complete,doc.Accepted,
		CASE 
		WHEN DATEADD(DAY,gp.AttendanceDuration, gp.AttendanceDate) < GETDATE() THEN 1
		WHEN DATEADD(DAY,gp.AttendanceDuration, gp.AttendanceDate) > GETDATE() THEN 0
		END AS Expired,emp.FullName AS Employer
		,co.FullName AS Company,pc.Status,pc.PersonCode FROM GatePass.Person p
		LEFT JOIN GatePass.PersonContract pc ON pc.PersonId = p.Id AND pc.PersonCode IS NOT NULL
		JOIN CM.Contract cont ON cont.Id = pc.ContractId
		JOIN GatePass.GatePass gp ON gp.PersonContractId = pc.Id AND gp. IsDelete = 0
		JOIN cm.CMDocument doc ON doc.Id = gp.DocumentId
		JOIN GatePass.GatePassDetail gpd ON gpd.GatePassId = gp.Id AND gpd.Accept = 1  AND gpd.RoleOrder = 8
		JOIN CM.Company co ON co.Id = doc.ContractorId
		JOIN CM.Company emp ON emp.Id = cont.EmployerId
		WHERE  doc.ProjectId = @ProjectId

	) SELECT ActiveGatepass.*,DATEADD(DAY,gpOld.AttendanceDuration,gpOld.AttendanceDate) AS PreviousGatePassExpDate,emp.FullName AS PreviousGatePassEmployer,co.FullName AS PreviousGatePassCompany,pc.PersonCode AS PreviousPersonCode FROM ActiveGatePass 
	LEFT JOIN GatePass.GatePass gpOld ON gpOld.Id = ActiveGatepass.PreviousActiveGatePassId
	LEFT JOIN GatePass.PersonContract pc ON pc.Id = gpOld.PersonContractId
	LEFT JOIN CM.Contract cont ON cont.Id = pc.ContractId
	LEFT JOIN cm.CMDocument doc ON doc.Id = gpOld.DocumentId
	LEFT JOIN GatePass.GatePassDetail gpd ON gpd.GatePassId = gpOld.Id AND gpd.Accept = 1  AND gpd.RoleOrder = 8
	LEFT JOIN CM.Company co ON co.Id = doc.ContractorId
	LEFT JOIN CM.Company emp ON emp.Id = cont.EmployerId
		
	WHERE ActiveGatepass.IsRevoke = 0 AND ActiveGatepass.Complete = 1 AND ActiveGatepass.Accepted = 1 AND ActiveGatepass.Expired = 0
END
GO
/****** Object:  StoredProcedure [GatePass].[ActiveGatePassListExpireMode]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[ActiveGatePassListExpireMode]
@ProjectId INT
AS
BEGIN
	;WITH ActiveGatepass AS (

		SELECT  ROW_NUMBER() OVER (PARTITION BY p.NationalCode,doc.Complete,doc.Accepted ORDER BY gp.Id DESC) RowNumber, LEAD(gp.Id) OVER (PARTITION BY p.NationalCode,doc.Complete,doc.Accepted ORDER BY gp.Id DESC) PreviousActiveGatePassId,doc.Id AS DocumentId,gp.Id AS GatePassId,p.Id AS PersonId,pc.Id AS PersonContractId,pc.ContractId,cont.EmployerId,cont.ContractorId,p.NationalCode,DATEADD(DAY,gp.AttendanceDuration, gp.AttendanceDate) AS [ExpireDate],gp.IsRevoke,doc.Complete,doc.Accepted,
		CASE 
		WHEN DATEADD(DAY,gp.AttendanceDuration, gp.AttendanceDate) < GETDATE() THEN 1
		WHEN DATEADD(DAY,gp.AttendanceDuration, gp.AttendanceDate) > GETDATE() THEN 0
		END AS Expired,emp.FullName AS Employer
		,co.FullName AS Company,pc.Status,pc.PersonCode FROM GatePass.Person p
		LEFT JOIN GatePass.PersonContract pc ON pc.PersonId = p.Id AND pc.PersonCode IS NOT NULL
		JOIN CM.Contract cont ON cont.Id = pc.ContractId
		JOIN GatePass.GatePass gp ON gp.PersonContractId = pc.Id AND gp. IsDelete = 0
		JOIN cm.CMDocument doc ON doc.Id = gp.DocumentId
		JOIN GatePass.GatePassDetail gpd ON gpd.GatePassId = gp.Id AND gpd.Accept = 1  AND gpd.RoleOrder = 8
		JOIN CM.Company co ON co.Id = doc.ContractorId
		JOIN CM.Company emp ON emp.Id = cont.EmployerId
		WHERE  doc.ProjectId = @ProjectId

	) SELECT ActiveGatepass.*,DATEADD(DAY,gpOld.AttendanceDuration,gpOld.AttendanceDate) AS PreviousGatePassExpDate,emp.FullName AS PreviousGatePassEmployer,co.FullName AS PreviousGatePassCompany,pc.PersonCode AS PreviousPersonCode FROM ActiveGatePass 
	LEFT JOIN GatePass.GatePass gpOld ON gpOld.Id = ActiveGatepass.PreviousActiveGatePassId
	LEFT JOIN GatePass.PersonContract pc ON pc.Id = gpOld.PersonContractId
	LEFT JOIN CM.Contract cont ON cont.Id = pc.ContractId
	LEFT JOIN cm.CMDocument doc ON doc.Id = gpOld.DocumentId
	LEFT JOIN GatePass.GatePassDetail gpd ON gpd.GatePassId = gpOld.Id AND gpd.Accept = 1  AND gpd.RoleOrder = 8
	LEFT JOIN CM.Company co ON co.Id = doc.ContractorId
	LEFT JOIN CM.Company emp ON emp.Id = cont.EmployerId
		
	WHERE ActiveGatepass.RowNumber = 1 AND ActiveGatepass.IsRevoke = 0 AND ActiveGatepass.Complete = 1 AND ActiveGatepass.Accepted = 1
END
GO
/****** Object:  StoredProcedure [GatePass].[AllActiveGatePass]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [GatePass].[AllActiveGatePass]
@ProjectId INT
AS
BEGIN
	;WITH ActiveGatepass AS (

		SELECT  ROW_NUMBER() OVER (PARTITION BY p.NationalCode,doc.Complete,doc.Accepted ORDER BY gp.Id DESC) RowNumber, LEAD(gp.Id) OVER (PARTITION BY p.NationalCode,doc.Complete,doc.Accepted ORDER BY gp.Id DESC) PreviousActiveGatePassId,doc.Id AS DocumentId,gp.Id AS GatePassId,p.Id AS PersonId,pc.Id AS PersonContractId,pc.ContractId,cont.EmployerId,cont.ContractorId,p.NationalCode,DATEADD(DAY,gp.AttendanceDuration, gp.AttendanceDate) AS [ExpireDate],gp.IsRevoke,doc.Complete,doc.Accepted,
		CASE 
		WHEN DATEADD(DAY,gp.AttendanceDuration, gp.AttendanceDate) < GETDATE() THEN 1
		WHEN DATEADD(DAY,gp.AttendanceDuration, gp.AttendanceDate) > GETDATE() THEN 0
		END AS Expired,emp.FullName AS Employer
		,co.FullName AS Company,pc.Status,pc.PersonCode FROM GatePass.Person p
		LEFT JOIN GatePass.PersonContract pc ON pc.PersonId = p.Id AND pc.PersonCode IS NOT NULL
		JOIN CM.Contract cont ON cont.Id = pc.ContractId
		JOIN GatePass.GatePass gp ON gp.PersonContractId = pc.Id AND gp. IsDelete = 0
		JOIN cm.CMDocument doc ON doc.Id = gp.DocumentId
		JOIN GatePass.GatePassDetail gpd ON gpd.GatePassId = gp.Id AND gpd.Accept = 1  AND gpd.RoleOrder = 8
		JOIN CM.Company co ON co.Id = doc.ContractorId
		JOIN CM.Company emp ON emp.Id = cont.EmployerId
		WHERE  doc.ProjectId = @ProjectId

	) SELECT ActiveGatepass.*,DATEADD(DAY,gpOld.AttendanceDuration,gpOld.AttendanceDate) AS PreviousGatePassExpDate,emp.FullName AS PreviousGatePassEmployer,co.FullName AS PreviousGatePassCompany,pc.PersonCode AS PreviousPersonCode FROM ActiveGatePass 
	LEFT JOIN GatePass.GatePass gpOld ON gpOld.Id = ActiveGatepass.PreviousActiveGatePassId
	LEFT JOIN GatePass.PersonContract pc ON pc.Id = gpOld.PersonContractId
	LEFT JOIN CM.Contract cont ON cont.Id = pc.ContractId
	LEFT JOIN cm.CMDocument doc ON doc.Id = gpOld.DocumentId
	LEFT JOIN GatePass.GatePassDetail gpd ON gpd.GatePassId = gpOld.Id AND gpd.Accept = 1  AND gpd.RoleOrder = 8
	LEFT JOIN CM.Company co ON co.Id = doc.ContractorId
	LEFT JOIN CM.Company emp ON emp.Id = cont.EmployerId
		
	WHERE ActiveGatepass.IsRevoke = 0 
END
GO
/****** Object:  StoredProcedure [GatePass].[ChangeCompany]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[ChangeCompany]
@PersonId INT,
@ContractId INT
AS
BEGIN
	UPDATE GatePass.PersonContract 
	SET GatePass.PersonContract.[Status] = 0
	WHERE PersonId = @PersonId

	INSERT INTO GatePass.PersonContract(PersonId, ContractId, PersonCode, Status)
	VALUES(@PersonId,@ContractId,NULL,DEFAULT)
END

GO
/****** Object:  StoredProcedure [GatePass].[CreateHistory]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[CreateHistory]
@ProjectId INT,
@UserId INT,
@PersonContractId INT,
@GatePassId INT,
@DocumentId INT,
@RoleId INT = NULL,
@AttendanceDuration_S INT = NULL,
@AttendanceDuration INT = NULL,
@JobPositionId_S INT = NULL,
@JobPositionId INT = NULL,
@JobPosition_S NVARCHAR(100) = NULL,
@JobPosition NVARCHAR(100) = NULL
AS
BEGIN
	
	BEGIN TRY
	BEGIN TRAN

	-- Create History For Person Job Position		
	INSERT INTO GatePass.PersonHistory 
	(
		ProjectId,
		RoleId,
		JobPositionId_S,
		JobPositionId,
		JobPosition_S,
		JobPosition,
		CreatedBy,
		CreatedDate
	)
	VALUES
	(
		@ProjectId,
		@RoleId,
		@JobPositionId_S,
		@JobPositionId,
		@JobPosition_S,
		@JobPosition,
		@UserId,
		GETDATE()
	)

	-- Create History For GatePass Request

	INSERT INTO GatePass.GatePassRequestHistory 
	(
		ProjectId,
		RoleId,
		AttendanceDuration_S,
		AttendanceDuration,
		CreatedBy,
		CreatedDate
	)
	VALUES
	(
		@ProjectId,
		@RoleId,
		@AttendanceDuration_S,
		@AttendanceDuration,
		@UserId,
		GETDATE()
	)

	COMMIT;
	END TRY
	BEGIN CATCH
	IF @@TRANCOUNT > 0 ROLLBACK;
	THROW;

	END CATCH

END

GO
/****** Object:  StoredProcedure [GatePass].[DeleteFaceIdentificationPlaces]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[DeleteFaceIdentificationPlaces]
@ProjectId int,
@Ids CM.IdsTable ReadOnly,
@UserId int
AS
BEGIN

	BEGIN TRY
		BEGIN TRAN

		DECLARE @HasAccess int
		SET @HasAccess = SGN.FnUserHasAcl(@ProjectId ,@UserId,'GatePass.DeleteFaceIdentificationPlaces')

		IF @HasAccess IS NULL OR @HasAccess = 0
			THROW 50002,'you don''t have access for delete opration on this form!',1


		UPDATE GatePass.FaceIdentificationPlace SET
			IsDelete = 1,
			DeletedBy = @UserId,
			[DeletedDate] = GETDATE()
		WHERE Id IN (SELECT * FROM @Ids)


		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACk;
		THROW
	END CATCH


END

GO
/****** Object:  StoredProcedure [GatePass].[DeleteGatePass]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [GatePass].[DeleteGatePass]
@DocumentId int,
@UserId int

AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		UPDATE CM.CMDocument SET 
			IsDelete = 1,
			DeletedOn = GETDATE(),
			DeletedBy = @UserId
		WHERE Id = @DocumentId
			
		UPDATE GatePass.GatePass SET 
			IsDelete = 1,
			DeletedDate = GETDATE(),
			DeletedBy = @UserId
		WHERE DocumentId = @DocumentId

		COMMIT;
	END TRY
	BEGIN CATCH

		ROLLBACK;
		;THROW;


	END CATCH
End
GO
/****** Object:  StoredProcedure [GatePass].[DeleteGatePassTypes]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[DeleteGatePassTypes]
@ProjectId int,
@Ids CM.IdsTable ReadOnly,
@UserId int
AS
BEGIN

	BEGIN TRY
		BEGIN TRAN

		DECLARE @HasAccess int
		SET @HasAccess = SGN.FnUserHasAcl(@ProjectId ,@UserId,'GatePass.DeleteGatePassTypes')

		IF @HasAccess IS NULL OR @HasAccess = 0
			THROW 50002,'you don''t have access for delete opration on this form!',1


		UPDATE GatePass.GatePassType SET
			IsDelete = 1,
			DeletedBy = @UserId,
			[DeletedDate] = GETDATE()
		WHERE Id IN (SELECT * FROM @Ids)


		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACk;
		THROW
	END CATCH


END

GO
/****** Object:  StoredProcedure [GatePass].[DeletePerson]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[DeletePerson]
@ProjectId INT,
@Id INT,
@UserId int
AS
BEGIN

	BEGIN TRY
		BEGIN TRAN

		DROP TABLE IF EXISTS #ActiveGatePassList
		DROP TABLE IF EXISTS #OngoingList



		DECLARE @HasActiveGatePass int = 0
		DECLARE @Ongoing int = 0




		Select emp.Id INTO #ActiveGatePassList From CM.CMDocument doc
			JOIN GatePass.GatePass gp On gp.DocumentId = doc.Id
			JOIN GatePass.GatePassDetail gpd ON gpd.GatePassId = gp.Id AND gpd.Accept = 1 AND gpd.RoleOrder = 5
			JOIN GatePass.Person emp On emp.Id = gp.EmployeeId
			WHERE doc.ProjectId = @ProjectId AND doc.IsDelete = 0 AND doc.IsVoid = 0 AND gp.IsDelete = 0 AND gp.IsRevoke = 0				
		SELECT emp.Id INTO #OngoingList FROM CM.CMDocument doc
			JOIN GatePass.GatePass gp On gp.DocumentId = doc.Id
			JOIN GatePass.Person emp ON emp.Id = gp.EmployeeId
			WHERE doc.ProjectId = @ProjectId AND gp.IsDelete = 0 AND doc.Posted = 1 

		IF @Id IN (SELECT Id FROM #ActiveGatePassList)
			THROW 50001,'The selected employee has active gatepass!',1

		IF @Id IN (SELECT Id FROM #OngoingList)
			THROW 50001,'The selected employee have ongoing document!',1


		UPDATE GatePass.Person SET
			IsDelete = 1,
			DeletedBy = @UserId,
			[DeletedDate] = GETDATE()
		WHERE Id = @Id

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACk;
		THROW
	END CATCH


END

GO
/****** Object:  StoredProcedure [GatePass].[DeleteSattisfactionLetter]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[DeleteSattisfactionLetter]
@ObjectId INT,
@UserId INT
AS
BEGIN

	BEGIN TRY
		BEGIN TRAN

		DECLARE @Now DATETIME
		SET @Now = GETDATE()

		UPDATE CM.CMDocument SET
			IsDelete  = 1,
			ModifiedBy = @UserId,
			ModifiedOn = @Now
			WHERE Id = @ObjectId

		UPDATE GatePass.LetterRequest SET
			DeletedBy = @UserId,
			DeletedDate = @Now
		WHERE DocumentId = @ObjectId


		COMMIT
	END TRY

	BEGIN CATCH
		ROLLBACK;
		THROW;
	END CATCH

END

GO
/****** Object:  StoredProcedure [GatePass].[EmptyGatePassData]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [GatePass].[EmptyGatePassData]

AS
BEGIN
	DELETE FROM GatePass.GatePassDetail
	DELETE FROM GatePass.GatePass
	DELETE FROM GatePass.LetterRequest
	DELETE FROM CM.CMAttachments WHERE ObjectName = 'GatePass'
	DELETE FROM CM.CMSign WHERE ObjectName = 'GatePass'
	DELETE FROM CM.CMDocument WHERE Type = 'GatePass'
	DELETE FROM GatePass.PersonFaceIdentification
	DELETE FROM GatePass.PersonContract
	DELETE FROM GatePass.Person

End
GO
/****** Object:  StoredProcedure [GatePass].[FetchActiveGatePassByPersonContractId]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchActiveGatePassByPersonContractId]
@ProjectId INT,
@PersonContractId INT
AS
BEGIN
	;WITH ActiveGatepass AS (

		SELECT  ROW_NUMBER() OVER (PARTITION BY p.NationalCode,doc.Complete,doc.Accepted ORDER BY gp.Id DESC) RowNumber, LEAD(gp.Id) OVER (PARTITION BY p.NationalCode,doc.Complete,doc.Accepted ORDER BY gp.Id DESC) PreviousActiveGatePassId,doc.Id AS DocumentId,gp.Id AS GatePassId,p.Id AS PersonId,pc.Id AS PersonContractId,pc.ContractId,cont.EmployerId,cont.ContractorId,p.NationalCode,DATEADD(DAY,gp.AttendanceDuration, gp.AttendanceDate) AS [ExpireDate],gp.IsRevoke,doc.Complete,doc.Accepted,
		CASE 
		WHEN DATEADD(DAY,gp.AttendanceDuration, gp.AttendanceDate) < GETDATE() THEN 1
		WHEN DATEADD(DAY,gp.AttendanceDuration, gp.AttendanceDate) > GETDATE() THEN 0
		END AS Expired,emp.FullName AS Employer
		,co.FullName AS Company,pc.Status,pc.PersonCode FROM GatePass.Person p
		LEFT JOIN GatePass.PersonContract pc ON pc.PersonId = p.Id AND pc.PersonCode IS NOT NULL
		JOIN CM.Contract cont ON cont.Id = pc.ContractId
		JOIN GatePass.GatePass gp ON gp.PersonContractId = pc.Id AND gp. IsDelete = 0
		JOIN cm.CMDocument doc ON doc.Id = gp.DocumentId
		JOIN GatePass.GatePassDetail gpd ON gpd.GatePassId = gp.Id AND gpd.Accept = 1  AND gpd.RoleOrder = 8
		JOIN CM.Company co ON co.Id = doc.ContractorId
		JOIN CM.Company emp ON emp.Id = cont.EmployerId
		WHERE  doc.ProjectId = @ProjectId

	) SELECT ActiveGatepass.*,DATEADD(DAY,gpOld.AttendanceDuration,gpOld.AttendanceDate) AS PreviousGatePassExpDate,emp.FullName AS PreviousGatePassEmployer,co.FullName AS PreviousGatePassCompany,pc.PersonCode AS PreviousPersonCode FROM ActiveGatePass 
	LEFT JOIN GatePass.GatePass gpOld ON gpOld.Id = ActiveGatepass.PreviousActiveGatePassId
	LEFT JOIN GatePass.PersonContract pc ON pc.Id = gpOld.PersonContractId
	LEFT JOIN CM.Contract cont ON cont.Id = pc.ContractId
	LEFT JOIN cm.CMDocument doc ON doc.Id = gpOld.DocumentId
	LEFT JOIN GatePass.GatePassDetail gpd ON gpd.GatePassId = gpOld.Id AND gpd.Accept = 1  AND gpd.RoleOrder = 8
	LEFT JOIN CM.Company co ON co.Id = doc.ContractorId
	LEFT JOIN CM.Company emp ON emp.Id = cont.EmployerId
		
	WHERE ActiveGatepass.PersonContractId =@PersonContractId  AND ActiveGatepass.IsRevoke = 0 AND ActiveGatepass.Complete = 1 AND ActiveGatepass.Accepted = 1 AND ActiveGatepass.Expired = 0
END
GO
/****** Object:  StoredProcedure [GatePass].[FetchAttachment]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GatePass].[FetchAttachment]
@ProjectId int,
@ObjectId INT
AS 
BEGIN

	SELECT cmatt.Id, cmatt.ProjectId, cmatt.ObjectName, cmatt.ObjectId, cmatt.stream_id, cmatt.CreatedDate, cmatt.CreatedUserId, cmatt.IsDelete, cmatt.IsUsed, cmatt.CustomType, cmatt.FileType, cmatt.FileName, cmatt.Remark, cmatt.DeletedDate, cmatt.DeletedUserId, cmatt.DeletedOn, cmatt.DeletedBy, cmatt.Type, gatt.Id, gatt.DocumentId, gatt.GatePassId, gatt.AttachmentId, gatt.PersonContractId, gatt.IsDelete, gatt.CreatedBy, gatt.CreatedDate, gatt.UpdatedBy, gatt.UpdatedDate, gatt.DeletedBy, gatt.DeletedDate FROM CM.CMAttachments cmatt
	JOIN GatePass.Attachment gatt ON gatt.AttachmentId = cmatt.Id
	JOIN GatePass.PersonContract pc ON pc.ContractId = cmatt.ObjectId
	WHERE cmatt.ProjectId = @ProjectId AND cmatt.ObjectName = 'GatePass' AND cmatt.ObjectId = @ObjectId
END
GO
/****** Object:  StoredProcedure [GatePass].[FetchAttachmentLetter]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GatePass].[FetchAttachmentLetter]
@ProjectId int,
@ObjectId INT
AS 
BEGIN

	SELECT cmatt.Id, cmatt.ProjectId, cmatt.ObjectName, cmatt.ObjectId, cmatt.stream_id, cmatt.CreatedDate, cmatt.CreatedUserId, cmatt.IsDelete, cmatt.IsUsed, cmatt.CustomType, cmatt.FileType, cmatt.FileName, cmatt.Remark, cmatt.DeletedDate, cmatt.DeletedUserId, cmatt.DeletedOn, cmatt.DeletedBy, cmatt.Type,'GatePass.ftAttachmentGatePass' AS FileTableName  FROM CM.CMAttachments cmatt
	WHERE cmatt.ProjectId = @ProjectId AND cmatt.ObjectName = 'GatePass' AND cmatt.ObjectId = @ObjectId
END
GO
/****** Object:  StoredProcedure [GatePass].[FetchAttachmentSafe]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchAttachmentSafe]

@ProjectId INT,
@UserId INT,
@ObjectId INT

AS
BEGIN

	DECLARE @Has_ShowAllAttachment_ACL BIT  = 0;
	SET @Has_ShowAllAttachment_ACL = SGN.FnUserHasAcl(@ProjectId,@UserId,N'GatePass.ShowAllAttachment')
	
	DECLARE @PersonId INT 
	SELECT @PersonId = PersonId FROM GatePass.PersonContract WHERE Id = @ObjectId


	SELECT att.Id,att.[FileName],att.CustomType,att.Remark,usr.FullName AS [User],'GatePass.ftAttachmentGatePass' AS FileTableName FROM Cm.CMAttachments att
	JOIN GatePass.PersonContract pc ON pc.Id = att.ObjectId AND pc.PersonId = @PersonId
	JOIN GatePass.ftAttachmentGatePass ft ON ft.stream_id = att.stream_id
	JOIN CM.[USER] usr ON usr.Id = att.CreatedUserId
	WHERE att.ObjectName = 'GatePass' AND (@Has_ShowAllAttachment_ACL = 1 OR att.ObjectId = @ObjectId ) AND att.IsDelete = 0
END

GO
/****** Object:  StoredProcedure [GatePass].[FetchEnabledGatePasses]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GatePass].[FetchEnabledGatePasses]
@ProjectId int
AS 
BEGIN


	DROP TABLE IF EXISTS #HasActiveGatePass
			
	-- SELECT Active GatePasses --------------------
	Select doc.ProjectId,p.Id,doc.ContractId,doc.CompanyId AS EmployerId,doc.ContractorId,gp.Id AS GatePassId,gp.DocumentId,gp.PersonContractId,p.NationalCode,gp.IsRevoke,gpd.Accept,DATEADD(DAY,gp.AttendanceDuration,gp.AttendanceDate) AS GatePassExpire INTO #HasActiveGatePass From CM.CMDocument doc
		JOIN GatePass.GatePass gp On gp.DocumentId = doc.Id
		JOIN GatePass.GatePassDetail gpd ON gpd.GatePassId = gp.Id AND gpd.Accept = 1 AND gpd.RoleOrder = 8
		JOIN GatePass.PersonContract pc ON pc.Id = gp.PersonContractId
		JOIN GatePass.Person p On p.Id = pc.PersonId
		WHERE doc.ProjectId = @ProjectId AND doc.IsDelete = 0 AND doc.IsVoid = 0 AND gp.IsDelete = 0 AND gp.IsRevoke = 0 AND doc.Complete = 1 AND doc.Accepted = 1 AND pc.Status = 1

	SELECT	ProjectId, Id, ContractId, EmployerId, ContractorId, GatePassId, DocumentId, PersonContractId, NationalCode, IsRevoke, Accept, GatePassExpire FROM #HasActiveGatePass

END
GO
/****** Object:  StoredProcedure [GatePass].[FetchFaceIdentificationPlace]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchFaceIdentificationPlace]
@ProjectId int
AS
BEGIN
	SELECT fid.Id,fid.ProjectId,fid.[Name],fid.[EnName],CM.FnProjectName(fid.ProjectId) As Project,u.FullName As CreatedBy,fid.CreatedDate FROM GatePass.FaceIdentificationPlace fid
	JOIN CM.[User] u On u.Id = fid.CreatedBy
	WHERE fid.ProjectId = @ProjectId AND IsDelete = 0
END

GO
/****** Object:  StoredProcedure [GatePass].[FetchFaceIdPlaces]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchFaceIdPlaces]

AS
BEGIN
	SELECT fid.Id,fid.ProjectId,fid.[Name],fid.[EnName],CM.FnProjectName(fid.ProjectId) As Project,u.FullName As CreatedBy,fid.CreatedDate FROM GatePass.FaceIdentificationPlace fid
	JOIN CM.[User] u On u.Id = fid.CreatedBy
END

GO
/****** Object:  StoredProcedure [GatePass].[FetchFaceIdPlacesByPersonId]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GatePass].[FetchFaceIdPlacesByPersonId]
@EmployeeId int

AS
BEGIN 

SELECT fid.Id,fid.[Name] FROM GatePass.PersonFaceIdentification efid
JOIN GatePass.FaceIdentificationPlace fid ON fid.Id = efid.FaceIdentificationId


WHERE EmployeeId = @EmployeeId

END
GO
/****** Object:  StoredProcedure [GatePass].[FetchGatePassRequestItem]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GatePass].[FetchGatePassRequestItem]
@ProjectId INT,
@ObjectId INT,
@GatePassId INT
AS
BEGIN
	SELECT doc.Id, doc.ProjectId, doc.ReportNo, doc.CreatedBy, doc.Posted, doc.CreateDate, doc.Complete, doc.Accepted, doc.CompanyId, doc.Type, doc.ModifiedOn, doc.ModifiedBy, doc.DisciplineId, doc.ContractorId, doc.ContractId, doc.UnitId, doc.Type2, doc.Remark, doc.DocumentOwnersRole, doc.Approved, gp.Id AS GatePassId, gp.PersonContractId, gp.RequestTypeId, gp.UnitRequestId, gp.Unit, gp.AttendanceDate, gp.AttendanceDuration, gp.GatePassTypeId, gp.JobPositionId, gp.JobPosition, gp.Description,gp.CreatedBy, gp.CreatedDate, p.Id AS PersonId, p.ProjectId, p.UnitId, p.JobPositionId, p.NationalCode, p.FirstName, p.EnFirstName, p.LastName, p.EnLastName,CONCAT(p.FirstName,' ',p.LastName) AS FullName,gpdHR.Accept AS HR_Accept,gpdGatePassIssuer.Accept AS GatePassIssuer_Accept, p.FatherName, p.EnFatherName, p.GenderId, p.CardCode, p.BirthDate, p.BirthCityId, p.CardIssuanceCityId, p.FatherBirthCityId, p.MotherBirthCityId, p.NativeCode, p.Identifier,p.MobileNo, p.PhoneNo, p.TrackingCode, p.Address,pc.Id AS PersonContractId
		
	 FROM CM.CMDocument doc
	INNER JOIN GatePass.GatePass gp ON gp.DocumentId = doc.Id
	INNER JOIN GatePass.PersonContract pc ON pc.Id = gp.PersonContractId
	INNER JOIN GatePass.Person p ON p.Id = pc.PersonId
	LEFT JOIN GatePass.GatePassDetail gpdHR ON gpdHR.GatePassId = gp.Id AND gpdHR.RoleOrder = 5
	LEFT JOIN GatePass.GatePassDetail gpdGatePassIssuer ON gpdGatePassIssuer.GatePassId = gp.Id AND gpdGatePassIssuer.RoleOrder = 8
	WHERE doc.ProjectId = @ProjectId AND doc.Id = @ObjectId AND gp.Id = @gatePassId
END

GO
/****** Object:  StoredProcedure [GatePass].[FetchGatePassTypes]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchGatePassTypes]
@ProjectId int
AS
BEGIN
	SELECT gpt.Id, gpt.ProjectId, gpt .[Name], gpt.[EnName],gpt.[Color],CM.FnProjectName(gpt.ProjectId) AS Project, usr.FullName As CreatedBy,gpt.CreatedDate   FROM GatePass.GatePassType gpt
	JOIN CM.[User] usr ON usr.Id = gpt.CreatedBy
	WHERE gpt.ProjectId = @ProjectId AND gpt.IsDelete = 0
	ORDER BY CreatedDate DESC
END

GO
/****** Object:  StoredProcedure [GatePass].[FetchItemAttachment]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchItemAttachment]

@ProjectId INT,
@DocumentId INT,
@ObjectId INT

AS
BEGIN	
	SELECT att.Id,att.[FileName],att.IsUsed,att.IsDelete,att.CustomType,att.Remark,usr.FullName AS [User],'GatePass.ftAttachmentGatePass' AS FileTableName,'Show' AS ShowFile FROM CM.CMAttachments att
	JOIN GatePass.Attachment gatt ON gatt.AttachmentId = att.Id  AND gatt.DocumentId = @DocumentId
	JOIN GatePass.ftAttachmentGatePass ft ON ft.stream_id = att.stream_id
	JOIN CM.[USER] usr ON usr.Id = att.CreatedUserId
	WHERE att.ProjectId = @ProjectId AND att.ObjectName = 'GatePass' AND att.ObjectId = @ObjectId  AND att.IsUsed = 1 AND att.IsDelete = 0 AND gatt.IsDelete = 0

END

GO
/****** Object:  StoredProcedure [GatePass].[FetchLetterByDocumentId]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchLetterByDocumentId]
@DocumentId INT
AS
BEGIN

	SELECT doc.Id, doc.ProjectId,doc.ContractId,doc.CompanyId,doc.ContractorId, doc.CreatedBy, doc.DisciplineId,p.Id AS PersonId,doc.ReportNo,p.FirstName, p.LastName,c1.FullName AS Employer, c2.FullName AS Contractor, doc.[Type],ou.[Name] AS Discipline,  doc.Type2, doc.Remark, doc.DocumentOwnersRole, doc.IsDelete, doc.PostedOn, doc.Posted,doc.Accepted, doc.Complete,u1.FullName AS CreatedUser, doc.CreateDate  FROM CM.CMDocument doc
	INNER JOIN CM.[User] u1 ON u1.Id = doc.CreatedBy
	INNER JOIN CM.[Company] c1 ON c1.Id = doc.CompanyId
	INNER JOIN CM.[Company] c2 ON c2.Id = doc.ContractorId
	INNER JOIN CM.OrganizationUnit ou ON ou.Id = doc.DisciplineId
	INNER JOIN GatePass.LetterRequest lr ON lr.DocumentId = doc.Id
	INNER  JOIN GatePass.Person p ON p.Id = lr.PersonId
	WHERE doc.Id = @DocumentId

END

GO
/****** Object:  StoredProcedure [GatePass].[FetchNewRequestByDocumentIdForEdit]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GatePass].[FetchNewRequestByDocumentIdForEdit]
@DocumentId int

AS
BEGIN

	SELECT NewId() As RowIndex,doc.Id As DocumentId,gp.Id,pc.Id AS PersonContractId,pc.ContractId AS ContractId,emp.Id AS EmployerId,contractor.Id AS ContractorId,doc.ProjectId,doc.CompanyId,doc.ReportNo,doc.Complete,doc.Accepted,doc.Posted,doc.IsDelete,emp.FullName As Employer,doc.CreatedBy As UserId,p.Id As PersonId,CONCAT(p.FirstName,' ',p.LastName) AS Person,p.JobPositionId As PositionId,jp.[Name] As Position,gp.GatePassTypeId,gpt.Color As GatePassType,gp.RequestTypeId,	
	CASE
		WHEN gp.RequestTypeId = 0 THEN N'New(جدید)'
		WHEN gp.RequestTypeId = 1 THEN N'HoldOver(تمدید)'
		WHEN gp.RequestTypeId = 2 THEN N'Guest(مهمان)'
	END AS RequestType,
	gp.UnitRequestId As RequestUnitId,ou.[Name] As RequestUnit,gp.AttendanceDate,gp.AttendanceDuration As AttendanceDurationDay,
	gp.[Description] As Remark
	 FROM CM.CMDocument doc
	JOIN GatePass.GatePass gp ON gp.DocumentId = doc.Id
	JOIN GatePass.GatePassType gpt ON gpt.Id = gp.GatePassTypeId
	JOIN CM.OrganizationUnit ou ON ou.Id = gp.UnitRequestId
	JOIN GatePass.PersonContract pc ON pc.Id = gp.PersonContractId
	JOIN CM.Contract cont ON cont.Id = pc.ContractId
	JOIN CM.Company emp ON emp.Id = cont.EmployerId 
	JOIN CM.Company contractor ON contractor.Id = cont.ContractorId 
	JOIN GatePass.Person p ON p.Id = pc.PersonId	
	JOIN Cm.JobPosition jp ON jp.Id = p.JobPositionId
 	WHERE doc.Id = @DocumentId AND gp.IsDelete = 0


END

GO
/****** Object:  StoredProcedure [GatePass].[FetchOngoingPersonDocument]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchOngoingPersonDocument]

@ProjectId INT,
@ContractId INT,
@NationalCode CHAR(10)

AS
BEGIN

	DROP TABLE IF EXISTS #Ongoing
	
	-- Select OnGoing GatePass ---------------------
	SELECT doc.ReportNo,doc.Posted,doc.Accepted,doc.Complete,CONCAT(p.FirstName,' ',p.LastName ) Person,p.NationalCode INTO #Ongoing FROM CM.CMDocument doc
		JOIN GatePass.GatePass gp On gp.DocumentId = doc.Id
		LEFT JOIN GatePass.GatePassDetail gpd ON gpd.GatePassId = gp.Id AND gpd.RoleOrder = 8
		JOIN GatePass.PersonContract pc ON pc.Id = gp.PersonContractId
		JOIN GatePass.Person p ON p.Id = pc.PersonId
		WHERE doc.ProjectId = @ProjectId AND pc.ContractId = @ContractId AND gp.IsDelete = 0 AND p.NationalCode = @NationalCode AND doc.Complete = 0 AND  (gpd.Accept IS NULL OR gpd.Accept = 0)

	SELECT ReportNo, Posted, Accepted, Complete, Person, NationalCode FROM #Ongoing
				
END

GO
/****** Object:  StoredProcedure [GatePass].[FetchPerson]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GatePass].[FetchPerson]
    @ProjectId INT,
    @UserId INT
AS
BEGIN
    DECLARE @ContractTemp TABLE
    (
        Id INT,
        EmployerId INT,
        ContractorId INT,
        ContractorSymbol NVARCHAR(20),
        EmployerSymbol NVARCHAR(20),
        Contractor NVARCHAR(250),
        Employer NVARCHAR(250),
        [Contract] NVARCHAR(300)
    );
    INSERT INTO @ContractTemp
    (
        Id,
        EmployerId,
        ContractorId,
        ContractorSymbol,
        EmployerSymbol,
        Contractor,
        Employer,
        Contract
    )
    EXEC CM.FetchContractsCombo @ProjectId = @ProjectId,
                                @UserId = @UserId,
                                @Acl = 'GatePass.Company';
    WITH PersonCTE
    AS (SELECT ROW_NUMBER() OVER (PARTITION BY NationalCode ORDER BY PersonContractId DESC) RowNumber,
               *
        FROM
        (
            SELECT p.Id,
                   p.ProjectId,
                   pc.Id AS PersonContractId,
                   c.Id AS ContractId,
                   p.GenderId,
                   p.BirthCityId,
                   p.CardIssuanceCityId,
                   p.FatherBirthCityId,
                   p.MotherBirthCityId,
                   p.UnitId,
                   p.JobPositionId,
                   CM.FnProjectName(p.ProjectId) AS Project,
                   cont.Symbol AS Contractor,
                   emp.Symbol AS Employer,
                   p.NationalCode,
                   CASE
                       WHEN p.GenderId = 0 THEN
                           'Male (آقا)'
                       WHEN p.GenderId = 1 THEN
                           'Female (خانم)'
                   END AS [Gender],
                   CASE
                       WHEN p.NativeCode = 0 THEN
                           'None-Native (غیربومی)'
                       WHEN p.NativeCode = 1 THEN
                           'Native (بومی)'
                       WHEN p.NativeCode = 2 THEN
                           'Native-Khuzestan (بومی خوزستان)'
                   END AS [NativeStatus],
                   p.FirstName,
                   p.EnFirstName,
                   p.LastName,
                   p.EnLastName,
                   ou.[Name] Unit,
                   jp.[Name] JobPosition,
                   p.FatherName,
                   p.EnFatherName,
                   p.CardCode,
                   p.BirthDate,
                   c1.Name AS BirthCity,
                   c2.Name AS CardIssuanceCity,
                   c3.Name AS FatherBirthCity,
                   c4.Name AS MotherBirthCity,
                   p.Identifier,
				   p.MobileNo,
				   p.PhoneNo,
                   p.TrackingCode,
                   p.[Address],
				   pc.Status AS IsActive,
                   p.IsDelete,
                   u.FullName AS CreatedBy,
                   p.CreateDate,
				   pc.PersonCode,
				   NULL AS [Action]
            FROM GatePass.Person p
                JOIN GatePass.PersonContract pc
                    ON pc.PersonId = p.Id
                JOIN CM.Contract c
                    ON c.Id = pc.ContractId
                JOIN CM.Company emp
                    ON emp.Id = c.EmployerId
                JOIN CM.Company cont
                    ON cont.Id = c.ContractorId
                JOIN CM.City c1
                    ON c1.Id = p.BirthCityId
                JOIN CM.City c2
                    ON c2.Id = p.CardIssuanceCityId
                JOIN CM.City c3
                    ON c3.Id = p.FatherBirthCityId
                JOIN CM.City c4
                    ON c4.Id = p.MotherBirthCityId
                JOIN CM.OrganizationUnit ou
                    ON ou.Id = p.UnitId
                       AND ou.ProjectId = @ProjectId
                JOIN CM.JobPosition jp
                    ON jp.Id = p.JobPositionId
                       AND jp.ProjectId = @ProjectId
                JOIN CM.[User] u
                    ON u.Id = p.CreatedBy
            WHERE p.ProjectId = @ProjectId
        ) personData
       )
    SELECT *
    FROM PersonCTE
    WHERE PersonCTE.RowNumber = 1 AND PersonCTE.IsActive = 1
          AND PersonCTE.ContractId IN (
                                          SELECT Id FROM @ContractTemp
                                      )
									  ORDER BY PersonCTE.PersonContractId DESC
	
END;

GO
/****** Object:  StoredProcedure [GatePass].[FetchPersonAddress]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchPersonAddress]

AS
BEGIN
	SELECT [Address] FROm GatePass.Person
END

GO
/****** Object:  StoredProcedure [GatePass].[FetchPersonById]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchPersonById]
@ProjectId int,
@EmployeeId int
AS
BEGIN

	SELECT TOP (1) emp.Id,pc.Id AS PersonContractId,c.Id AS ContractId,c.ContractorId AS ContractorId ,c.EmployerId AS EmployerId,emp.ProjectId,emp.GenderId,emp.BirthCityId,emp.CardIssuanceCityId,emp.FatherBirthCityId,emp.MotherBirthCityId,emp.UnitId,emp.JobPositionId,CM.FnProjectName(emp.ProjectId) As Project,
		emp.NationalCode,
		CASE 
			WHEN emp.GenderId = 0 THEN 'Male (آقا)'
			WHEN emp.GenderId = 1 THEN 'Female (خانم)'
		END  AS [Gender],
		emp.FirstName,emp.EnFirstName,emp.LastName,emp.EnLastName,ou.[Name] Unit,jp.[Name] JobPosition,emp.FatherName,emp.EnFatherName,emp.CardCode,emp.BirthDate,c1.Name As BirthCity,c2.Name As CardIssuanceCity,c3.Name AS FatherBirthCity,c4.Name AS MotherBirthCity,emp.TrackingCode,u.FullName AS CreatedBy,emp.CreateDate FROM GatePass.Person emp
	JOIN GatePass.PersonContract pc ON PC.PersonId = emp.Id
	JOIN CM.Contract c ON c.Id = pc.ContractId
	JOIN CM.City c1 ON c1.Id = emp.BirthCityId
	JOIN CM.City c2 ON c2.Id = emp.CardIssuanceCityId
	JOIN CM.City c3 ON c3.Id = emp.FatherBirthCityId
	JOIN CM.City c4 ON c4.Id = emp.MotherBirthCityId
	JOIN CM.OrganizationUnit ou ON ou.Id = emp.UnitId AND ou.ProjectId = @ProjectId
	JOIN CM.JobPosition jp ON jp.Id = emp.JobPositionId AND jp.ProjectId =@ProjectId
	JOIN CM.[User] u ON u.Id = emp.CreatedBy
	WHERE emp.ProjectId =@ProjectId And emp.Id = @EmployeeId AND emp.IsDelete = 0
	ORDER BY pc.Id DESC


END

GO
/****** Object:  StoredProcedure [GatePass].[FetchPersonByNationalCode]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchPersonByNationalCode]
@NationalCode CHAR(10)
AS
BEGIN	


	SELECT TOP (1) p.Id,pc.Id AS PersonContractId,pc.ContractId,cont.Id AS ContractorId,emp.Id AS EmployerId, p.ProjectId, p.UnitId, p.JobPositionId, p.NationalCode, p.FirstName, p.EnFirstName, p.LastName, p.EnLastName, p.FatherName, p.EnFatherName, p.GenderId, p.CardCode, p.BirthDate, p.BirthCityId, p.CardIssuanceCityId, p.FatherBirthCityId, p.MotherBirthCityId, p.NativeCode, p.Identifier, p.TrackingCode, p.Address, p.IsDelete,cont.Symbol AS ContractorSymbol,emp.Symbol AS EmployerSymbol,emp.FullName AS Employer,CONCAT(cont.FullName,' =>',emp.Symbol) AS Contractor,pc.Status,pc.PersonCode FROM GatePass.Person p
		JOIN GatePass.PersonContract pc ON pc.PersonId = p.Id
		JOIN CM.Contract c ON c.Id = pc.ContractId
		JOIN CM.Company emp ON emp.Id = c.EmployerId
		JOIN CM.Company cont ON cont.Id = c.ContractorId
		 WHERE p.NationalCode = @NationalCode AND  p.IsDelete = 0
		 ORDER BY pc.Id DESC
END

GO
/****** Object:  StoredProcedure [GatePass].[FetchPersonCodeByPersonContractId]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [GatePass].[FetchPersonCodeByPersonContractId]

@ProjectId INT,
@PersonContractId INT,
@PersonCode NVARCHAR(25) Output

AS 
BEGIN

DECLARE @Counter NVARCHAR(10);

SELECT @Counter = Value FROM CM.CMConfig WHERE Scope =  'GatePass' AND Name = 'PersonCodeCounter' AND ProjectId = @ProjectId
SELECT @Counter

SELECT @PersonCode = PersonCode FROM GatePass.PersonContract WHERE Id = @PersonContractId
IF @PersonCode IS NULL OR @PersonCode = '0'
	SET @PersonCode = @Counter

END

GO
/****** Object:  StoredProcedure [GatePass].[FetchPersonCombo]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchPersonCombo]
@ProjectId INT,
@ContractId INT
AS
BEGIN


	DECLARE @ActiveGatePassList TABLE(RowNumber INT,PreviousActiveGatePassId INT,DocumentId INT,GatePassId INT,PersonId INT,PersonContractId INT,ContractId INT, EmployerId INT, ContractorId INT,NationalCode CHAR(10),ExpireDate DATETIME,IsRevoke BIT,Complete BIT,Acepted BIT,Expired BIT,Employer VARCHAR(120),Company VARCHAR(120),Status BIT,PersonCode VARCHAR(50),PreviousGatePassExpDate DATETIME,PreviousGatePassEmployer NVARCHAR(200),PreviousGatePassCompany NVARCHAR(200),PreviousPersonCode VARCHAR(50))

	INSERT @ActiveGatePassList(RowNumber,PreviousActiveGatePassId,DocumentId,GatePassId, PersonId, PersonContractId, ContractId, EmployerId, ContractorId, NationalCode, ExpireDate,IsRevoke,Complete,Acepted, Expired, Employer, Company, Status, PersonCode,PreviousGatePassExpDate,PreviousGatePassEmployer,PreviousGatePassCompany,PreviousPersonCode)
		EXEC GatePass.ActiveGatePassListExpireMode
			@ProjectId = @ProjectId

 
	SELECT p.Id,pc.Id AS PersonContractId,c.Id AS ContractId,emp.Id AS EmployerId,cont.Id AS ContractorId,p.NationalCode,CONCAT(p.FirstName,' ',p.LastName) AS FullName,CONCAT(cont.FullName,'=>',emp.Symbol) AS Company,
	CASE
		WHEN agpl.ExpireDate IS NULL THEN NULL
		WHEN agpl.ExpireDate IS NOT NULL THEN expDate.JalaliDate
	END AS GatePassExpireDate,
	agpl.Expired,
	agpl.ContractId AS ActiveGatePassContractId
	FROM GatePass.Person p
	JOIN GatePass.PersonContract pc ON pc.PersonId = p.Id AND pc.Status = 1 
	JOIN CM.Contract c ON c.Id = pc.ContractId
	JOIN CM.Company emp ON emp.Id = c.EmployerId
	JOIN CM.Company cont ON cont.Id = c.ContractorId
	LEFT JOIN @ActiveGatePassList agpl ON agpl.NationalCode = p.NationalCode
	LEFT JOIN CM.JalaliDate expDate ON expDate.MiladiDate = agpl.ExpireDate
	WHERE p.ProjectId =@ProjectId AND pc.ContractId = @ContractId AND p.IsDelete = 0
	ORDER BY pc.Id


END

GO
/****** Object:  StoredProcedure [GatePass].[FetchPersonComboForLetterRequestForm]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchPersonComboForLetterRequestForm]
@ProjectId int,
@UserId INT
AS
BEGIN
	RETURN NULL;
	--DECLARE @CompanyTableTemp TABLE(Id int,[Name] nvarchar(100),[Symbol] varchar(30),FullName nvarchar(133));

	--INSERT INTO @CompanyTableTemp 
	--EXEC GatePass.FetchPersonCompanies 
	--	@ProjectId = @ProjectId,
	--	@UserId = @UserId


	--SELECT emp.Id,emp.CompanyId,CONCAT (emp.FirstName,' ',emp.LastName) As FullName,co.FullName As Company
	--FROM GatePass.Person emp
	--JOIN CM.Company co ON co.Id = emp.CompanyId
	--WHERE emp.ProjectId =@ProjectId And emp.CompanyId IN (Select Id FROM @CompanyTableTemp) AND emp.IsDelete = 0
	--ORDER BY emp.UpdatedDate DESC,emp.Id DESC

END

GO
/****** Object:  StoredProcedure [GatePass].[FetchPersonCompanies]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchPersonCompanies]
@ProjectId int,
@UserId int
AS
BEGIN

	DECLARE @ACL varchar(55)= N'GatePass.EmployeeCompany'

	select co.Id,co.[Name],co.Symbol,co.[FullName] from CM.CMAclItem acli
		inner join CM.CMAcl acl on acl.Id = acli.AclId
		inner join CM.Company co on co.Id = acli.[Value]
		where acl.ProjectId =@ProjectId and acl.UserId= @UserId and acl.[Name]=@ACL and acl.Allow=1
	UNION
	select co.Id,co.[Name],co.Symbol,co.[FullName] from CM.CMAclItem acli
		inner join CM.CMAcl acl on acl.Id = acli.AclId
		inner join CM.UsersGroups ugs on ugs.GroupId = acl.GroupId
		inner join CM.Company co on co.Id = acli.[Value]
		where acl.ProjectId =@ProjectId and ugs.UserId= @UserId and acl.[Name]=@ACL and acl.Allow=1
		order by co.Id
END

GO
/****** Object:  StoredProcedure [GatePass].[FetchRequestById]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchRequestById]
@DocumentId INT
AS
BEGIN
	
	SELECT doc.Id,doc.ProjectId,doc.CompanyId,doc.CreatedBy,CM.FnProjectName(doc.ProjectId) as Project,doc.ReportNo,doc.[Type],doc.DocumentOwnersRole,
	CM.FnGetDocumentStatusText(doc.Posted,doc.Complete,doc.Accepted) AS DocumentStatus
	,doc.IsDelete,doc.Posted,doc.Complete,doc.Accepted,u1.FullName as CreatedUser,jdCreatedDate.JalaliDate As CreatedDate FROM CM.CMDocument doc
	JOIN CM.Company co ON co.Id = doc.CompanyId
	JOIN CM.[User] u1 ON u1.Id = doc.CreatedBy
	JOIN CM.JalaliDate jdCreatedDate On jdCreatedDate.MiladiDate = CONVERT(date,doc.CreateDate,23)
	WHERE doc.[Type] = 'GatePass' AND doc.Type2 IS NULL And doc.Id = @DocumentId
END

GO
/****** Object:  StoredProcedure [GatePass].[FetchRequestItems]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GatePass].[FetchRequestItems]
@ProjectId int,
@UserId int,
@ObjectId int
AS
BEGIN

	DECLARE @ActiveGatePassList TABLE(RowNumber INT,PreviousActiveGatePassId INT,DocumentId INT,GatePassId INT,PersonId INT,PersonContractId INT,ContractId INT, EmployerId INT, ContractorId INT,NationalCode CHAR(10),ExpireDate DATETIME,IsRevoke BIT,Complete BIT,Acepted BIT,Expired BIT,Employer VARCHAR(120),Company VARCHAR(120),Status BIT,PersonCode VARCHAR(50),PreviousGatePassExpDate DATETIME,PreviousGatePassEmployer NVARCHAR(200),PreviousGatePassCompany NVARCHAR(200),PreviousPersonCode VARCHAR(50))

	INSERT @ActiveGatePassList(RowNumber,PreviousActiveGatePassId,DocumentId,GatePassId, PersonId, PersonContractId, ContractId, EmployerId, ContractorId, NationalCode, ExpireDate,IsRevoke,Complete,Acepted, Expired, Employer, Company, Status, PersonCode,PreviousGatePassExpDate,PreviousGatePassEmployer,PreviousGatePassCompany,PreviousPersonCode)
		EXEC GatePass.ActiveGatePassListExpireMode
			@ProjectId = @ProjectId

	DECLARE @Has_CreateRequest_Acl bit = 0
	SET @Has_CreateRequest_Acl = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.Expert')

	DECLARE @Has_HeadOfUnit_Acl bit = 0
	SET @Has_HeadOfUnit_Acl = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.HeadOfUnit')

	DECLARE @Has_Security_Manager_Acl bit = 0
	SET @Has_Security_Manager_Acl = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.Security_Manager')

	DECLARE @Has_ODCC_SEI_Manager_Acl bit = 0
	SET @Has_ODCC_SEI_Manager_Acl = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.ODCC_SEI_Manager')

	DECLARE @Has_HR_Manager_Acl bit = 0
	SET @Has_HR_Manager_Acl = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.HR_Manager')

	DECLARE @Has_HSE_Manager_Acl bit = 0
	SET @Has_HSE_Manager_Acl = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.HSE_Manager')

	DECLARE @Has_NIOEC_Manager_Acl bit = 0
	SET @Has_NIOEC_Manager_Acl = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.NIOEC_Manager')

	DECLARE @Has_GatePassIssuer bit = 0
	SET @Has_GatePassIssuer = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.GatePassIssuer')

		
	IF @Has_CreateRequest_Acl = 0 AND @Has_HeadOfUnit_Acl = 0 AND @Has_Security_Manager_Acl = 0 AND 
		@Has_ODCC_SEI_Manager_Acl = 0 AND @Has_HR_Manager_Acl = 0 AND @Has_HSE_Manager_Acl = 0 AND
		@Has_NIOEC_Manager_Acl = 0 AND @Has_GatePassIssuer = 0
		BEGIN
			RAISERROR('You dont have any access to show this document!',16,1)
			RETURN;
		END

	
	IF @Has_Security_Manager_Acl = 1 
		BEGIN
			SELECT doc.Id,doc.ProjectId,doc.CompanyId, gp.Id GatePassId,gp.PersonContractId,p.Id AS PersonId,doc.DocumentOwnersRole,p.NationalCode,p.FirstName,p.LastName,p.CardCode,p.BirthDate,gpt.Color As [GatePassType],ou.[Name] AS Unit,gp.AttendanceDate,gp.AttendanceDuration,gp.[Description] AS Remark,
			 CM.FnGetDocumentStatusText(doc.Posted,doc.Complete,doc.Accepted) AS DocumentStatus
			,IIF(hr.Accept IS NULL,CAST(0 AS BIT),hr.Accept) AS [HR_Confirm]
			,IIF(hse.Accept IS NULL,CAST(0 AS BIT),hse.Accept) AS [HSE_Confirm]
			,IIF(gpIssuer.Accept IS NULL,CAST(0 AS BIT),gpIssuer.Accept) AS [GPIssuer_Confirm],
			agpl.PersonCode AS PersonCode,
			CASE
				WHEN agpl.PreviousGatePassEmployer IS NULL THEN agpl.Employer
				WHEN agpl.PreviousGatePassEmployer IS NOT NULL THEN  agpl.PreviousGatePassEmployer			 
			END AS PreviousGatePassEmployer,
			CASE
				WHEN agpl.PreviousGatePassCompany IS NULL THEN agpl.Company
				WHEN agpl.PreviousGatePassCompany  IS NOT NULL THEN  agpl.PreviousGatePassCompany 		 
			END AS PreviousGatePassCompany,
			CASE
				WHEN agpl.PreviousPersonCode IS NULL THEN agpl.PersonCode
				WHEN agpl.PreviousPersonCode  IS NOT NULL THEN  agpl.PreviousPersonCode 		 
			END AS PreviousPersonCode,
				jdate.JalaliDate AS PreviousExpireDate,
			agpl.Expired AS PreviousExpired,
			'Show Files' AS Files 	
			FROM CM.CMDocument doc
			JOIN GatePass.GatePass gp ON gp.DocumentId = doc.Id
			LEFT JOIN GatePass.GatePassDetail hr  ON hr.GatePassId = gp.Id AND hr.RoleOrder = 5
			LEFT JOIN GatePass.GatePassDetail hse  ON hse.GatePassId = gp.Id AND hse.RoleOrder = 6
			LEFT JOIN GatePass.GatePassDetail gpIssuer  ON gpIssuer.GatePassId = gp.Id AND gpIssuer.RoleOrder = 8
			JOIN GatePass.GatePassType gpt ON gpt.Id = gp.GatePassTypeId
			JOIN CM.OrganizationUnit ou ON ou.Id = gp.UnitRequestId
			JOIN CM.JobPosition jp ON jp.Id = gp.JobPositionId
			JOIN GatePass.PersonContract pc ON pc.Id = gp.PersonContractId
			JOIN GatePass.Person p ON p.Id = pc.PersonId
			LEFT JOIN @ActiveGatePassList agpl ON agpl.NationalCode = p.NationalCode AND (agpl.GatePassId = gp.Id OR agpl.PreviousActiveGatePassId IS NULL)
			JOIN CM.City birthcity ON birthcity.Id = p.BirthCityId
			JOIN CM.City cardIssueCity ON cardIssueCity.Id = p.CardIssuanceCityId
			JOIN CM.City fatherBirthCity ON fatherBirthCity.Id = p.FatherBirthCityId
			JOIN CM.City motherBirthCity ON motherBirthCity.Id = p.MotherBirthCityId
				LEFT JOIN CM.JalaliDate jdate ON jdate.MiladiDate = agpl.ExpireDate
			WHERE doc.Id = @ObjectId AND gp.IsDelete = 0
			return

		END


	IF @Has_HR_Manager_Acl = 1
	BEGIN
		SELECT doc.Id,doc.ProjectId,doc.CompanyId,gp.Id GatePassId,gp.PersonContractId,p.Id AS PersonId,doc.DocumentOwnersRole,p.NationalCode,p.FirstName,p.LastName,p.FatherName,p.CardCode,p.BirthDate,birthcity.[Name] As BirthCity,cardIssueCity.[Name] As CardIssuanceCity,fatherBirthCity.[Name] As FatherBirthCity,motherBirthCity.[Name] AS MotherBirthCity,p.Identifier,gpt.Color As [GatePassType],ou.[Name] AS Unit,gp.AttendanceDate,gp.AttendanceDuration,jp.[Name] As JobPosition,p.TrackingCode,gp.[Description] AS Remark,
			 CM.FnGetDocumentStatusText(doc.Posted,doc.Complete,doc.Accepted) AS DocumentStatus
			,IIF(hr.Accept IS NULL,CAST(0 AS BIT),hr.Accept) AS [HR_Confirm]
			,IIF(hse.Accept IS NULL,CAST(0 AS BIT),hse.Accept) AS [HSE_Confirm]
			,IIF(gpIssuer.Accept IS NULL,CAST(0 AS BIT),gpIssuer.Accept) AS [GPIssuer_Confirm]
			,agpl.PersonCode AS PersonCode,
			CASE
				WHEN agpl.PreviousGatePassEmployer IS NULL THEN agpl.Employer
				WHEN agpl.PreviousGatePassEmployer IS NOT NULL THEN  agpl.PreviousGatePassEmployer			 
			END AS PreviousGatePassEmployer,
			CASE
				WHEN agpl.PreviousGatePassCompany IS NULL THEN agpl.Company
				WHEN agpl.PreviousGatePassCompany  IS NOT NULL THEN  agpl.PreviousGatePassCompany 		 
			END AS PreviousGatePassCompany,
			CASE
				WHEN agpl.PreviousPersonCode IS NULL THEN agpl.PersonCode
				WHEN agpl.PreviousPersonCode  IS NOT NULL THEN  agpl.PreviousPersonCode 		 
			END AS PreviousPersonCode,
			jdate.JalaliDate AS PreviousExpireDate,
			agpl.Expired AS PreviousExpired,
			'Show Files' AS Files
			FROM CM.CMDocument doc
			JOIN GatePass.GatePass gp ON gp.DocumentId = doc.Id
			LEFT JOIN GatePass.GatePassDetail hr  ON hr.GatePassId = gp.Id AND hr.RoleOrder = 5
			LEFT JOIN GatePass.GatePassDetail hse  ON hse.GatePassId = gp.Id AND hse.RoleOrder = 6
			LEFT JOIN GatePass.GatePassDetail gpIssuer  ON gpIssuer.GatePassId = gp.Id AND gpIssuer.RoleOrder = 8
			JOIN GatePass.GatePassType gpt ON gpt.Id = gp.GatePassTypeId
			JOIN CM.OrganizationUnit ou ON ou.Id = gp.UnitRequestId
			JOIN CM.JobPosition jp ON jp.Id = gp.JobPositionId
			JOIN GatePass.PersonContract pc ON pc.Id = gp.PersonContractId
			JOIN GatePass.Person p ON p.Id = pc.PersonId
			LEFT JOIN @ActiveGatePassList agpl ON agpl.NationalCode = p.NationalCode AND (agpl.GatePassId = gp.Id OR agpl.PreviousActiveGatePassId IS NULL)
			JOIN CM.City birthcity ON birthcity.Id = p.BirthCityId
			JOIN CM.City cardIssueCity ON cardIssueCity.Id = p.CardIssuanceCityId
			JOIN CM.City fatherBirthCity ON fatherBirthCity.Id = p.FatherBirthCityId
			JOIN CM.City motherBirthCity ON motherBirthCity.Id = p.MotherBirthCityId
				LEFT JOIN CM.JalaliDate jdate ON jdate.MiladiDate = agpl.ExpireDate
			WHERE doc.Id = @ObjectId AND gp.IsDelete = 0

			RETURN;
	END

	SELECT doc.Id,doc.ProjectId,doc.CompanyId,gp.Id GatePassId,gp.PersonContractId,p.Id AS PersonId,doc.DocumentOwnersRole,p.NationalCode,p.FirstName,p.LastName,p.FatherName,p.CardCode,p.BirthDate,birthcity.[Name] As BirthCity,cardIssueCity.[Name] As CardIssuanceCity,fatherBirthCity.[Name] As FatherBirthCity,motherBirthCity.[Name] AS MotherBirthCity,p.Identifier,gpt.Color As [GatePassType],ou.[Name] AS Unit,gp.AttendanceDate,gp.AttendanceDuration,jp.[Name] As JobPosition,p.TrackingCode,gp.[Description] AS Remark,
			 CM.FnGetDocumentStatusText(doc.Posted,doc.Complete,doc.Accepted) AS DocumentStatus
			,IIF(hr.Accept IS NULL,CAST(0 AS BIT),hr.Accept) AS [HR_Confirm]
			,IIF(hse.Accept IS NULL,CAST(0 AS BIT),hse.Accept) AS [HSE_Confirm]
			,IIF(gpIssuer.Accept IS NULL,CAST(0 AS BIT),gpIssuer.Accept) AS [GPIssuer_Confirm]
			,agpl.PersonCode AS PersonCode,
			CASE
				WHEN agpl.PreviousGatePassEmployer IS NULL THEN agpl.Employer
				WHEN agpl.PreviousGatePassEmployer IS NOT NULL THEN  agpl.PreviousGatePassEmployer			 
			END AS PreviousGatePassEmployer,
			CASE
				WHEN agpl.PreviousGatePassCompany IS NULL THEN agpl.Company
				WHEN agpl.PreviousGatePassCompany  IS NOT NULL THEN  agpl.PreviousGatePassCompany 		 
			END AS PreviousGatePassCompany,
			CASE
				WHEN agpl.PreviousPersonCode IS NULL THEN agpl.PersonCode
				WHEN agpl.PreviousPersonCode  IS NOT NULL THEN  agpl.PreviousPersonCode 		 
			END AS PreviousPersonCode,
			jdate.JalaliDate AS PreviousExpireDate,
			agpl.Expired AS PreviousExpired,
			'Show Files' AS Files
			FROM CM.CMDocument doc
			JOIN GatePass.GatePass gp ON gp.DocumentId = doc.Id
			LEFT JOIN GatePass.GatePassDetail hr  ON hr.GatePassId = gp.Id AND hr.RoleOrder = 5
			LEFT JOIN GatePass.GatePassDetail hse  ON hse.GatePassId = gp.Id AND hse.RoleOrder = 6
			LEFT JOIN GatePass.GatePassDetail gpIssuer  ON gpIssuer.GatePassId = gp.Id AND gpIssuer.RoleOrder = 8
			JOIN GatePass.GatePassType gpt ON gpt.Id = gp.GatePassTypeId
			JOIN CM.OrganizationUnit ou ON ou.Id = gp.UnitRequestId
			JOIN CM.JobPosition jp ON jp.Id = gp.JobPositionId
			JOIN GatePass.PersonContract pc ON pc.Id = gp.PersonContractId
			JOIN GatePass.Person p ON p.Id = pc.PersonId
			LEFT JOIN @ActiveGatePassList agpl ON agpl.NationalCode = p.NationalCode AND (agpl.GatePassId = gp.Id OR agpl.PreviousActiveGatePassId IS NULL)
			JOIN CM.City birthcity ON birthcity.Id = p.BirthCityId
			JOIN CM.City cardIssueCity ON cardIssueCity.Id = p.CardIssuanceCityId
			JOIN CM.City fatherBirthCity ON fatherBirthCity.Id = p.FatherBirthCityId
			JOIN CM.City motherBirthCity ON motherBirthCity.Id = p.MotherBirthCityId
				LEFT JOIN CM.JalaliDate jdate ON jdate.MiladiDate = agpl.ExpireDate
			WHERE doc.Id = @ObjectId AND gp.IsDelete = 0

			RETURN;

END
GO
/****** Object:  StoredProcedure [GatePass].[FetchRequestList]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [GatePass].[FetchRequestList]
@ProjectId int,
@UserId int
As

BEGIN

    DECLARE @ContractTemp TABLE
    (
        Id INT,
        EmployerId INT,
        ContractorId INT,
        ContractorSymbol NVARCHAR(20),
        EmployerSymbol NVARCHAR(20),
        Contractor NVARCHAR(250),
        Employer NVARCHAR(250),
        [Contract] NVARCHAR(300)
    );
    INSERT INTO @ContractTemp
    (
        Id,
        EmployerId,
        ContractorId,
        ContractorSymbol,
        EmployerSymbol,
        Contractor,
        Employer,
        Contract
    )
    EXEC CM.FetchContractsCombo @ProjectId = @ProjectId,
                                @UserId = @UserId,
                                @Acl = 'GatePass.Company';




	SELECT doc.Id,doc.ProjectId,doc.CompanyId,doc.CreatedBy,doc.ReportNo,doc.DocumentOwnersRole,
	
	CM.FnGetDocumentStatusText(doc.Posted,doc.Complete,doc.Accepted) AS DocumentStatus

	,doc.IsDelete,doc.Posted,doc.Complete,doc.Accepted,u1.FullName as CreatedUser,doc.CreateDate FROM CM.CMDocument doc
	JOIN CM.Company co ON co.Id = doc.CompanyId
	JOIN CM.[User] u1 ON u1.Id = doc.CreatedBy
	WHERE doc.[Type] = 'GatePass' AND doc.Type2 IS NULL And doc.ProjectId = @ProjectId And doc.ContractId IN(SELECT Id FROM @ContractTemp)
	ORDER BY doc.Id DESC

END
GO
/****** Object:  StoredProcedure [GatePass].[FetchSatticfactionLetterList]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchSatticfactionLetterList]
@ProjectId INT
AS
BEGIN
	SELECT doc.Id, doc.ProjectId,doc.ContractId,doc.CompanyId,doc.ContractorId, doc.CreatedBy, doc.DisciplineId,p.Id AS PersonId,doc.ReportNo,p.FirstName, p.LastName,c1.FullName AS Employer, c2.FullName AS Contractor, doc.[Type],ou.[Name] AS Discipline,  doc.Type2, doc.Remark, doc.DocumentOwnersRole, doc.IsDelete, doc.PostedOn, doc.Posted,doc.Accepted, doc.Complete,u1.FullName AS CreatedUser, doc.CreateDate FROM CM.CMDocument doc
	INNER JOIN CM.[User] u1 ON u1.Id = doc.CreatedBy
	INNER JOIN CM.[Company] c1 ON c1.Id = doc.CompanyId
	INNER JOIN CM.[Company] c2 ON c2.Id = doc.ContractorId
	INNER JOIN CM.OrganizationUnit ou ON ou.Id = doc.DisciplineId
	INNER JOIN GatePass.LetterRequest lr ON lr.DocumentId = doc.Id
	INNER  JOIN GatePass.Person p ON p.Id = lr.PersonId
	WHERE doc.[Type] = 'GatePass' AND doc.[Type2] = 'Letter' AND doc.ProjectId = @ProjectId
	ORDER BY  lr.Id DESC
END

GO
/****** Object:  StoredProcedure [GatePass].[FetchSettings]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchSettings]
@ProjectId int,
@CompanyId int = NULL
AS
BEGIN


SELECT * FROM GatePass.Settings WHERE ProjectId = 1 AND (@CompanyId IS NULL OR CompanyId = @CompanyId)


END

GO
/****** Object:  StoredProcedure [GatePass].[FetchSettingsForEditor]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchSettingsForEditor]
@ProjectId int,
@CompanyId int = NULL
AS
BEGIN

SELECT Id,[CompanyId] As Company,[Name],[Value] FROM GatePass.Settings WHERE ProjectId = @ProjectId AND (@CompanyId IS NULL OR CompanyId = @CompanyId)


END

GO
/****** Object:  StoredProcedure [GatePass].[FetchUnits]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[FetchUnits]
@ProjectId INT
AS
BEGIN
	SELECT Id, IsDiscipline, Symbol, [Name] FROM cm.OrganizationUnit WHERE @ProjectId = @ProjectId
END

GO
/****** Object:  StoredProcedure [GatePass].[HSEAction]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[HSEAction]
@ProjectId INT,
@UserId INT,
@PersonContractId INT,
@RoleId INT = NULL,
@GatePassId INT,
@DocumentId INT,
@AttendanceDuration_S INT,
@AttendanceDuration INT,
@JobPositionId_S INT,
@JobPositionId INT,
@JobPosition_S NVARCHAR(100),
@JobPosition NVARCHAR(100)
AS
BEGIN
	
	BEGIN TRY
	BEGIN TRAN

	-- GET PersonId from @PersonContractId
	DECLARE @PersonId INT;
	SELECT @PersonId = PersonId FROM GatePass.PersonContract WHERE Id = @PersonContractId


	IF @PersonId IS NULL OR @PersonId = 0
		THROW 50002,'PersonId not found!',1;


	-- Update person data from hse unit
	UPDATE GatePass.GatePass SET
	JobPositionId = @JobPositionId,
	JobPosition = @JobPosition,
	AttendanceDuration = @AttendanceDuration,
	UpdatedBy = @UserId,
	UpdatedDate = GETDATE()
	WHERE Id = @GatePassId AND DocumentId = @DocumentId AND PersonContractId = @PersonContractId

	-- Create History For Person Job Position		
	INSERT INTO GatePass.PersonHistory 
	(
		ProjectId,
		RoleId,
		PersonContractId,
		PersonId,
		JobPositionId_S,
		JobPositionId,
		JobPosition_S,
		JobPosition,
		CreatedBy,
		CreatedDate
	)
	VALUES
	(
		@ProjectId,
		IIF(@RoleId IS NULL,6,@RoleId),
		@PersonContractId,
		@PersonId,
		@JobPositionId_S,
		@JobPositionId,
		@JobPosition_S,
		@JobPosition,
		@UserId,
		GETDATE()
	)

	-- Create History For GatePass Request

	INSERT INTO GatePass.GatePassRequestHistory 
	(
		ProjectId,
		DocumentId,
		GatePassId,
		RoleId,
		AttendanceDuration_S,
		AttendanceDuration,
		CreatedBy,
		CreatedDate
	)
	VALUES
	(
		@ProjectId,
		@DocumentId,
		@GatePassId,
		IIF(@RoleId IS NULL,6,@RoleId),
		@AttendanceDuration_S,
		@AttendanceDuration,
		@UserId,
		GETDATE()
	)

	COMMIT;
	END TRY
	BEGIN CATCH
	IF @@TRANCOUNT > 0 ROLLBACK;
	THROW;

	END CATCH

END

GO
/****** Object:  StoredProcedure [GatePass].[PrintReportCompanyWise]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GatePass].[PrintReportCompanyWise]
@ProjectId int,
@ObjectId int,
@UserId int
AS
BEGIN
	
	DECLARE @Has_CreateRequest_Acl bit = 0
	SET @Has_CreateRequest_Acl = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.Expert')

	DECLARE @Has_HeadOfUnit_Acl bit = 0
	SET @Has_HeadOfUnit_Acl = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.HeadOfUnit')

	DECLARE @Has_Security_Manager_Acl bit = 0
	SET @Has_Security_Manager_Acl = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.Security_Manager')

	DECLARE @Has_ODCC_SEI_Manager_Acl bit = 0
	SET @Has_ODCC_SEI_Manager_Acl = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.ODCC_SEI_Manager')

	DECLARE @Has_HR_Manager_Acl bit = 0
	SET @Has_HR_Manager_Acl = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.HR_Manager')

	DECLARE @Has_HSE_Manager_Acl bit = 0
	SET @Has_HSE_Manager_Acl = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.HSE_Manager')

	DECLARE @Has_NIOEC_Manager_Acl bit = 0
	SET @Has_NIOEC_Manager_Acl = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.NIOEC_Manager')

	DECLARE @Has_GatePassIssuer bit = 0
	SET @Has_GatePassIssuer = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.GatePassIssuer')

		
	IF @Has_CreateRequest_Acl = 0 AND @Has_HeadOfUnit_Acl = 0 AND @Has_Security_Manager_Acl = 0 AND 
		@Has_ODCC_SEI_Manager_Acl = 0 AND @Has_HR_Manager_Acl = 0 AND @Has_HSE_Manager_Acl = 0 AND
		@Has_NIOEC_Manager_Acl = 0 AND @Has_GatePassIssuer = 0
		BEGIN
			RAISERROR('You dont have any access to show this document!',16,1)
			RETURN
		END




	IF @Has_Security_Manager_Acl = 1
	BEGIN
		SELECT 
		RequestTypeId AS RequestType,doc.ReportNo,p.FirstName,p.LastName,p.NationalCode,p.CardCode,'-' AS FatherName,'-' AS BirthDate,'-' As BirthCity,'-' As CardIssuanceCity,'-'As FatherBirthCity,'-' As MotherBirthCity,gpt.Name As GatePassType,'-' As JobPosition,cu.Name AS RequestedUnit,jd1.JalaliDate As AttendanceDate,gp.AttendanceDuration As Duration, p.TrackingCode,gp.Description,jd2.JalaliDate As CreatedDate	
		FROM CM.CMDocument doc
		JOIN GatePass.GatePass gp ON gp.DocumentId = doc.Id
		JOIN GatePass.PersonContract pc ON pc.Id = gp.PersonContractId
		JOIN GatePass.Person p ON p.Id = pc.PersonId
		JOIN GatePass.GatePassType gpt ON gpt.Id = gp.GatePassTypeId
		JOIN CM.OrganizationUnit cu On cu.Id = gp.UnitRequestId
		JOIN CM.JobPosition jp ON jp.Id = gp.JobPositionId
		JOIN CM.Company co ON co.Id = doc.CompanyId
		JOIN CM.[User] usr ON usr.Id = doc.CreatedBy
		JOIN CM.City bthCity ON bthCity.Id = p.BirthCityId
		JOIN CM.City cardIssuCity ON cardIssuCity.Id = p.CardIssuanceCityId
		JOIN CM.City fatherBthCity ON fatherBthCity.Id = p.FatherBirthCityId
		JOIN CM.City motherBthCity ON motherBthCity.Id = p.MotherBirthCityId

		JOIN CM.JalaliDate jd1 ON jd1.MiladiDate = CONVERT(date,gp.AttendanceDate,23)
		JOIN CM.JalaliDate jd2 ON jd2.MiladiDate = CONVERT(date,doc.CreateDate,23)

		WHERE doc.ProjectId = @ProjectId AND doc.Id = @ObjectId AND doc.IsDelete = 0 AND gp.IsDelete = 0

		return
	END
	ELSE
	BEGIN
		SELECT 
		RequestTypeId AS RequestType,doc.ReportNo,p.FirstName,p.LastName,p.NationalCode,p.CardCode,p.FatherName,p.BirthDate,bthCity.Name As BirthCity,cardIssuCity.Name As CardIssuanceCity,fatherBthCity.Name As FatherBirthCity,motherBthCity.Name As MotherBirthCity,gpt.Name As GatePassType,jp.Name As JobPosition,cu.Name AS RequestedUnit,jd1.JalaliDate As AttendanceDate,gp.AttendanceDuration As Duration, p.TrackingCode,gp.Description,jd2.JalaliDate As CreatedDate	
		FROM CM.CMDocument doc
	    JOIN GatePass.GatePass gp ON gp.DocumentId = doc.Id
		JOIN GatePass.PersonContract pc ON pc.Id = gp.PersonContractId
		JOIN GatePass.Person p ON p.Id = pc.PersonId
		JOIN GatePass.GatePassType gpt ON gpt.Id = gp.GatePassTypeId
		JOIN CM.OrganizationUnit cu On cu.Id = gp.UnitRequestId
		JOIN CM.JobPosition jp ON jp.Id = gp.JobPositionId
		JOIN CM.Company co ON co.Id = doc.CompanyId
		JOIN CM.[User] usr ON usr.Id = doc.CreatedBy
		JOIN CM.City bthCity ON bthCity.Id = p.BirthCityId
		JOIN CM.City cardIssuCity ON cardIssuCity.Id = p.CardIssuanceCityId
		JOIN CM.City fatherBthCity ON fatherBthCity.Id = p.FatherBirthCityId
		JOIN CM.City motherBthCity ON motherBthCity.Id = p.MotherBirthCityId

		JOIN CM.JalaliDate jd1 ON jd1.MiladiDate = CONVERT(date,gp.AttendanceDate,23)
		JOIN CM.JalaliDate jd2 ON jd2.MiladiDate = CONVERT(date,doc.CreateDate,23)


		WHERE doc.ProjectId = 1 AND doc.Id = @ObjectId AND doc.IsDelete = 0 AND gp.IsDelete = 0

	END







END

GO
/****** Object:  StoredProcedure [GatePass].[PrintSignReportCompanyWise]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[PrintSignReportCompanyWise]
@ObjectId int
AS
BEGIN

Select sgn.[Role],sgn.CreateDate,usr.FullName,usr.SignImage  FROM Cm.CMSign sgn
JOIN CM.[User] usr ON usr.Id =  sgn.UserId
 WHERE ObjectId = @ObjectId AND sgn.Accepted = 1

END

GO
/****** Object:  StoredProcedure [GatePass].[ReportCompanyWise]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GatePass].[ReportCompanyWise] @ProjectId INT, @ContractId INT, @UserId INT
AS BEGIN
    DECLARE @Has_CreateRequest_Acl BIT=0;
    SET @Has_CreateRequest_Acl=SGN.FnUserHasAcl(@ProjectId, @UserId, 'GatePass.Expert');
    DECLARE @Has_HeadOfUnit_Acl BIT=0;
    SET @Has_HeadOfUnit_Acl=SGN.FnUserHasAcl(@ProjectId, @UserId, 'GatePass.HeadOfUnit');
    DECLARE @Has_Security_Manager_Acl BIT=0;
    SET @Has_Security_Manager_Acl=SGN.FnUserHasAcl(@ProjectId, @UserId, 'GatePass.Security_Manager');
    DECLARE @Has_ODCC_SEI_Manager_Acl BIT=0;
    SET @Has_ODCC_SEI_Manager_Acl=SGN.FnUserHasAcl(@ProjectId, @UserId, 'GatePass.ODCC_SEI_Manager');
    DECLARE @Has_HR_Manager_Acl BIT=0;
    SET @Has_HR_Manager_Acl=SGN.FnUserHasAcl(@ProjectId, @UserId, 'GatePass.HR_Manager');
    DECLARE @Has_HSE_Manager_Acl BIT=0;
    SET @Has_HSE_Manager_Acl=SGN.FnUserHasAcl(@ProjectId, @UserId, 'GatePass.HSE_Manager');
    DECLARE @Has_NIOEC_Manager_Acl BIT=0;
    SET @Has_NIOEC_Manager_Acl=SGN.FnUserHasAcl(@ProjectId, @UserId, 'GatePass.NIOEC_Manager');
    DECLARE @Has_GatePassIssuer BIT=0;
    SET @Has_GatePassIssuer=SGN.FnUserHasAcl(@ProjectId, @UserId, 'GatePass.GatePassIssuer');
    


	DECLARE @ActiveGatePassList TABLE(RowNumber INT,PreviousActiveGatePassId INT,DocumentId INT,GatePassId INT,PersonId INT,PersonContractId INT,ContractId INT, EmployerId INT, ContractorId INT,NationalCode CHAR(10),ExpireDate DATETIME,IsRevoke BIT,Complete BIT,Acepted BIT,Expired BIT,Employer VARCHAR(120),Company VARCHAR(120),Status BIT,PersonCode VARCHAR(50),PreviousGatePassExpDate DATETIME,PreviousGatePassEmployer NVARCHAR(200),PreviousGatePassCompany NVARCHAR(200),PreviousPersonCode VARCHAR(50))

	INSERT @ActiveGatePassList(RowNumber,PreviousActiveGatePassId,DocumentId,GatePassId, PersonId, PersonContractId, ContractId, EmployerId, ContractorId, NationalCode, ExpireDate,IsRevoke,Complete,Acepted, Expired, Employer, Company, Status, PersonCode,PreviousGatePassExpDate,PreviousGatePassEmployer,PreviousGatePassCompany,PreviousPersonCode)
	EXEC GatePass.ActiveGatePassListExpireMode
		@ProjectId = @ProjectId


    IF @Has_CreateRequest_Acl=0 AND @Has_HeadOfUnit_Acl=0 AND @Has_Security_Manager_Acl=0 AND @Has_ODCC_SEI_Manager_Acl=0 AND @Has_HR_Manager_Acl=0 AND @Has_HSE_Manager_Acl=0 AND @Has_NIOEC_Manager_Acl=0 AND @Has_GatePassIssuer=0 BEGIN
        RAISERROR('You dont have any access to show this document!', 16, 1);
        RETURN;
    END;




	-- Select for scuritymanager
    IF @Has_Security_Manager_Acl=1 
	BEGIN
    SELECT p.ProjectId, doc.Id AS DocumentId, gp.GatePassTypeId, pc.Id AS PersonContractId, cont.Id AS ContractId, cont.EmployerId, cont.ContractorId AS CompanyId, p.Id AS PersonId, doc.ReportNo, p.FirstName, p.LastName, p.NationalCode, p.CardCode, p.FatherName , gpt.Name AS GatePassColor, cu.[Name] AS Unit, jdAttendanceDate.JalaliDate AS AttendanceDate, jdExpireDate.JalaliDate AS ExpirationDate, gp.AttendanceDuration AS Duration, IIF((DATEDIFF(DAY, GETDATE(), DATEADD(DAY, gp.AttendanceDuration, gp.AttendanceDate))<0),0,(DATEDIFF(DAY, GETDATE(), DATEADD(DAY, gp.AttendanceDuration, gp.AttendanceDate)))) AS RemainDay,
	-- Case For get GatePassStatus
	CASE 
		WHEN doc.IsDelete=1 OR gp.IsDelete = 1 THEN 'Deleted'
		WHEN doc.IsDelete=0 AND gp.IsRevoke = 1 AND doc.Complete = 1 THEN 'Revoked' 
		WHEN doc.IsDelete=0 AND gp.IsRevoke = 0 AND GETDATE() > DATEADD(DAY, gp.AttendanceDuration, gp.AttendanceDate)  THEN 'Expired'
		WHEN doc.IsDelete=0 AND gp.IsRevoke = 0 AND GETDATE() < DATEADD(DAY, gp.AttendanceDuration, gp.AttendanceDate)  AND GPIssuerConfirm.Accept = 1 THEN 'Active'
		WHEN doc.Complete = 0 THEN 'In Progress'
		WHEN HRConfirm.Accept = 0 THEN 'HR Rejected'
		WHEN HSEConfirm.Accept = 0 THEN 'HSE Rejected' 
		WHEN GPIssuerConfirm.Accept = 0 THEN 'GPIssuer Rejected'
		WHEN doc.Accepted = 0 AND doc.Complete = 1 THEN 'Document Rejected'
	END AS [GatePassStatus], 	
	
	-- Case For get pass status active result 
	CASE 
		WHEN doc.IsDelete=1 OR gp.IsDelete = 1 THEN CAST(0 AS BIT)
		WHEN doc.IsDelete=0 AND gp.IsRevoke = 1 AND doc.Complete = 1 THEN CAST(0 AS BIT)
		WHEN doc.IsDelete=0 AND gp.IsRevoke = 0 AND GETDATE() > DATEADD(DAY, gp.AttendanceDuration, gp.AttendanceDate)  THEN CAST(0 AS BIT)
		WHEN doc.IsDelete=0 AND gp.IsRevoke = 0 AND GETDATE() < DATEADD(DAY, gp.AttendanceDuration, gp.AttendanceDate)  AND GPIssuerConfirm.Accept = 1 THEN CAST(1 AS BIT)
		WHEN GPIssuerConfirm.Accept = 0 THEN CAST(0 AS BIT)
		WHEN GPIssuerConfirm.Accept = 0 AND doc.Complete = 1 THEN CAST(0 AS BIT)
	END AS GatePassActive,

	HRConfirm.Accept AS HR,HSEConfirm.Accept AS HSE, GPIssuerConfirm.Accept AS GatePassIssuer, doc.CreateDate AS CreatedDate, 'Show Files' AS [Files]
    FROM GatePass.Person p
         LEFT JOIN GatePass.PersonContract pc ON pc.PersonId=p.Id --AND pc.Status = 1
         LEFT JOIN CM.Contract cont ON cont.Id=pc.ContractId
         LEFT JOIN GatePass.GatePass gp ON gp.PersonContractId=pc.Id AND pc.ContractId=@ContractId
         LEFT JOIN GatePass.GatePassDetail HRConfirm ON HRConfirm.GatePassId=gp.Id AND HRConfirm.RoleOrder=5
         LEFT JOIN GatePass.GatePassDetail HSEConfirm ON HSEConfirm.GatePassId=gp.Id AND HSEConfirm.RoleOrder=6
         LEFT JOIN GatePass.GatePassDetail GPIssuerConfirm ON GPIssuerConfirm.GatePassId=gp.Id AND GPIssuerConfirm.RoleOrder=8
         LEFT JOIN CM.CMDocument doc ON doc.Id=gp.DocumentId
		 LEFT JOIN @ActiveGatePassList agpl ON agpl.NationalCode = p.NationalCode AND (agpl.GatePassId = gp.Id OR agpl.PreviousActiveGatePassId IS NULL)
         LEFT JOIN GatePass.GatePassType gpt ON gpt.Id=gp.GatePassTypeId
         LEFT JOIN CM.OrganizationUnit cu ON cu.Id=gp.UnitRequestId
         LEFT JOIN CM.JobPosition jp ON jp.Id=gp.JobPositionId
         LEFT JOIN CM.Company co ON co.Id=cont.ContractorId
         LEFT JOIN CM.Company emp ON emp.Id=cont.EmployerId
         LEFT JOIN CM.[User] usr ON usr.Id=doc.CreatedBy
         LEFT JOIN CM.JalaliDate jdAttendanceDate ON jdAttendanceDate.MiladiDate=CONVERT(DATE, gp.AttendanceDate, 23)
         LEFT JOIN CM.JalaliDate jdExpireDate ON jdExpireDate.MiladiDate=CONVERT(DATE, DATEADD(DAY, gp.AttendanceDuration, gp.AttendanceDate), 23)
    WHERE pc.ContractId=@ContractId AND p.ProjectId=@ProjectId
    ORDER BY doc.Id DESC
	RETURN;
	End

	-- GSelect for general select 
    SELECT p.ProjectId, doc.Id AS DocumentId, gp.GatePassTypeId, pc.Id AS PersonContractId, cont.Id AS ContractId, cont.EmployerId, cont.ContractorId AS CompanyId, p.Id AS PersonId, doc.ReportNo, p.FirstName, p.LastName, p.NationalCode, p.CardCode, p.FatherName,emp.FullName AS Employer ,co.FullName AS Company, gpt.Name AS GatePassColor, jp.[Name] AS JobPosition, cu.[Name] AS Unit, jdAttendanceDate.JalaliDate AS AttendanceDate, jdExpireDate.JalaliDate AS ExpirationDate, gp.AttendanceDuration AS Duration, 0 AS RemainDay,doc.DocumentOwnersRole AS Owner,
	-- Case For get GatePassStatus
	CASE 
		WHEN doc.IsDelete=1 OR gp.IsDelete = 1 THEN 'Deleted'
		WHEN doc.IsDelete=0 AND gp.IsRevoke = 1 AND doc.Complete = 1 THEN 'Revoked' 
		WHEN doc.IsDelete=0 AND gp.IsRevoke = 0 AND GETDATE() > DATEADD(DAY, gp.AttendanceDuration, gp.AttendanceDate)  THEN 'Expired'
		WHEN doc.IsDelete=0 AND gp.IsRevoke = 0 AND GETDATE() < DATEADD(DAY, gp.AttendanceDuration, gp.AttendanceDate)  AND GPIssuerConfirm.Accept = 1 THEN 'Active'
		WHEN doc.Complete = 0 THEN 'In Progress'
		WHEN HRConfirm.Accept = 0 THEN 'HR Rejected'
		WHEN HSEConfirm.Accept = 0 THEN 'HSE Rejected' 
		WHEN GPIssuerConfirm.Accept = 0 THEN 'GPIssuer Rejected'
		WHEN doc.Accepted = 0 AND doc.Complete = 1 THEN 'Document Rejected'
	END AS [GatePassStatus], 	
	
	-- Case For get pass status active result 
	CASE 
		WHEN doc.IsDelete=1 OR gp.IsDelete = 1 THEN CAST(0 AS BIT)
		WHEN doc.IsDelete=0 AND gp.IsRevoke = 1 AND doc.Complete = 1 THEN CAST(0 AS BIT)
		WHEN doc.IsDelete=0 AND gp.IsRevoke = 0 AND GETDATE() > DATEADD(DAY, gp.AttendanceDuration, gp.AttendanceDate)  THEN CAST(0 AS BIT)
		WHEN doc.IsDelete=0 AND gp.IsRevoke = 0 AND GETDATE() < DATEADD(DAY, gp.AttendanceDuration, gp.AttendanceDate)  AND GPIssuerConfirm.Accept = 1 THEN CAST(1 AS BIT)
		WHEN GPIssuerConfirm.Accept = 0 THEN CAST(0 AS BIT)
		WHEN GPIssuerConfirm.Accept = 0 AND doc.Complete = 1 THEN CAST(0 AS BIT)
	END AS GatePassActive,


	agpl.PersonCode AS PersonCode,



	CASE
				WHEN agpl.PreviousGatePassEmployer IS NULL THEN agpl.Employer
				WHEN agpl.PreviousGatePassEmployer IS NOT NULL THEN  agpl.PreviousGatePassEmployer			 
			END AS PreviousGatePassEmployer,
	CASE
		WHEN agpl.PreviousGatePassCompany IS NULL THEN agpl.Company
		WHEN agpl.PreviousGatePassCompany  IS NOT NULL THEN  agpl.PreviousGatePassCompany 		 
	END AS PreviousGatePassCompany,
	CASE
		WHEN agpl.PreviousPersonCode IS NULL THEN agpl.PreviousPersonCode
		WHEN agpl.PreviousPersonCode  IS NOT NULL THEN  agpl.PersonCode 		 
	END AS PreviousPersonCode,
	 gp.IsRevoke, gp.IsDelete, doc.Posted, HRConfirm.Accept AS HR,HSEConfirm.Accept AS HSE, GPIssuerConfirm.Accept AS GatePassIssuer,
	doc.Accepted, doc.Complete, usr.FullName AS CreatedUser, doc.CreateDate AS CreatedDate, 'Show Files' AS [Files]
    FROM GatePass.Person p
         LEFT JOIN GatePass.PersonContract pc ON pc.PersonId=p.Id --AND pc.Status = 1
         LEFT JOIN CM.Contract cont ON cont.Id=pc.ContractId
         LEFT JOIN GatePass.GatePass gp ON gp.PersonContractId=pc.Id AND pc.ContractId=@ContractId
         LEFT JOIN GatePass.GatePassDetail HRConfirm ON HRConfirm.GatePassId=gp.Id AND HRConfirm.RoleOrder=5
         LEFT JOIN GatePass.GatePassDetail HSEConfirm ON HSEConfirm.GatePassId=gp.Id AND HSEConfirm.RoleOrder=6
         LEFT JOIN GatePass.GatePassDetail GPIssuerConfirm ON GPIssuerConfirm.GatePassId=gp.Id AND GPIssuerConfirm.RoleOrder=8
         LEFT JOIN CM.CMDocument doc ON doc.Id=gp.DocumentId
		 LEFT JOIN @ActiveGatePassList agpl ON agpl.NationalCode = p.NationalCode AND (agpl.GatePassId = gp.Id OR agpl.PreviousActiveGatePassId IS NULL)
         LEFT JOIN GatePass.GatePassType gpt ON gpt.Id=gp.GatePassTypeId
         LEFT JOIN CM.OrganizationUnit cu ON cu.Id=gp.UnitRequestId
         LEFT JOIN CM.JobPosition jp ON jp.Id=gp.JobPositionId
         LEFT JOIN CM.Company co ON co.Id=cont.ContractorId
         LEFT JOIN CM.Company emp ON emp.Id=cont.EmployerId
         LEFT JOIN CM.[User] usr ON usr.Id=doc.CreatedBy
         LEFT JOIN CM.JalaliDate jdAttendanceDate ON jdAttendanceDate.MiladiDate=CONVERT(DATE, gp.AttendanceDate, 23)
         LEFT JOIN CM.JalaliDate jdExpireDate ON jdExpireDate.MiladiDate=CONVERT(DATE, DATEADD(DAY, gp.AttendanceDuration, gp.AttendanceDate), 23)
    WHERE pc.ContractId=@ContractId AND p.ProjectId=@ProjectId
    ORDER BY doc.Id DESC
END;
GO
/****** Object:  StoredProcedure [GatePass].[ReservePersonCodeCounter]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [GatePass].[ReservePersonCodeCounter]
@ProjectId INT,
@UserId INT,
@PersonContractId INT
AS
BEGIN
	BEGIN TRY
	BEGIN TRAN

	-- if need to check permission check here

	DECLARE @Value VARCHAR(55);
	DECLARE @Counter INT;
	SELECT @Value = Value FROM CM.Config WHERE ProjectId = @ProjectId AND Scope = 'GatePass' AND [Name] ='PersonCodeCounter'
	IF @Value IS NOT NULL 
	BEGIN 
	SET @Counter = CAST(@value AS INT);
	UPDATE GatePass.PersonContract SET
	PersonCode = @Counter
	WHERE Id = @PersonContractId

	UPDATE CM.Config SET
	Value = CAST((@Counter+1) AS VARCHAR(55))
	WHERE ProjectId = @ProjectId AND Scope = 'GatePass' AND Name = 'PersonCodeCounter'


	END 
	ELSE
		THROW 50005,'Counter value not found',1;
	COMMIT;
	END TRY
	BEGIN CATCH
	IF @@TRANCOUNT > 0 ROLLBACK;
	THROW;
	END CATCH
END
GO
/****** Object:  StoredProcedure [GatePass].[RevokeGatePasses]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[RevokeGatePasses]
@ProjectId INT,
@UserId INT,
@PersonId CHAR(10)
AS
BEGIN

	BEGIN TRY		
		-- Temp table for active gatepasses
		DECLARE @ActiveGatePassList TABLE(RowNumber INT,PreviousActiveGatePassId INT,DocumentId INT,GatePassId INT,PersonId INT,PersonContractId INT,ContractId INT,EmployerId INT,ContractorId INT,NationalCode CHAR(10),ExpireDate DATETIME,IsRevoke BIT,Complete BIT,Accepted BIT,Expired BIT,Employer NVARCHAR(100),Company NVARCHAR(100),Status BIT,PersonCode VARCHAR(20),PreviousGatePassExpDate DATETIME,PreviousGatePassEmployer NVARCHAR(100),PreviousGatePassCompany NVARCHAR(100),PreviousPersonCode VARCHAR(20)
		);

		-- insert active gatepassess to temp table
		INSERT @ActiveGatePassList
		EXEC GatePass.AllActiveGatePass @ProjectId= @ProjectId;

		UPDATE GatePass.GatePass SET
		IsRevoke = 1,
		UpdatedBy = @UserId,
		UpdatedDate = GETDATE()
		WHERE Id IN (
		SELECT gp.Id FROM GatePass.GatePass gp
		INNER JOIN @ActiveGatePassList agpl ON agpl.gatepassid = gp.Id
		INNER JOIN GatePass.PersonContract pc ON pc.Id = gp.PersonContractId
		INNER JOIN GatePass.Person p ON p.Id = pc.PersonId
		WHERE p.Id = @PersonId )
	END TRY

	BEGIN CATCH
		;THROW;
	END CATCH

		
END



GO
/****** Object:  StoredProcedure [GatePass].[RevokeOldGatePasses]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[RevokeOldGatePasses]
@ProjectId INT,
@UserId INT,
@GatePassId INT,
@NationalCode CHAR(10)
AS
BEGIN

		 
	DECLARE @ActiveGatePassList TABLE(RowNumber INT,PreviousActiveGatePassId INT,DocumentId INT,GatePassId INT,PersonId INT,PersonContractId INT,ContractId INT, EmployerId INT, ContractorId INT,NationalCode CHAR(10),ExpireDate DATETIME,IsRevoke BIT,Complete BIT,Acepted BIT,Expired BIT,Employer VARCHAR(120),Company VARCHAR(120),Status BIT,PersonCode VARCHAR(50),PreviousGatePassExpDate DATETIME,PreviousGatePassEmployer NVARCHAR(200),PreviousGatePassCompany NVARCHAR(200),PreviousPersonCode VARCHAR(50))

	INSERT @ActiveGatePassList(RowNumber,PreviousActiveGatePassId,DocumentId,GatePassId, PersonId, PersonContractId, ContractId, EmployerId, ContractorId, NationalCode, ExpireDate,IsRevoke,Complete,Acepted, Expired, Employer, Company, Status, PersonCode,PreviousGatePassExpDate,PreviousGatePassEmployer,PreviousGatePassCompany,PreviousPersonCode)
	EXEC GatePass.ActiveGatePassList
		@ProjectId = @ProjectId

		UPDATE GatePass.GatePass SET
		IsRevoke = 1,
		UpdatedBy = @UserId,
		UpdatedDate = GETDATE()
		WHERE Id IN (
		SELECT gp.Id FROM GatePass.GatePass gp
		INNER JOIN GatePass.PersonContract pc ON pc.Id = gp.PersonContractId AND pc.Status = 1
		INNER JOIN GatePass.Person p ON p.Id = pc.PersonId
		WHERE p.NationalCode = @NationalCode AND gp.Id <> @gatePassId )
END

GO
/****** Object:  StoredProcedure [GatePass].[SaveAttachment]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[SaveAttachment]

@ProjectId as int,
@UserId as int,
@ObjectName as nvarchar(255),
@ObjectId as int,
@IsUsed BIT = 0,
@Files as CM.FileItemType READONLY

AS
BEGIN
	Begin TRY
		Begin Transaction		

	  --Merge for FileTicketAttachment table
	  MERGE [GatePass].[ftAttachmentGatePass] as t
		USING @Files As s 
		ON (t.[name] = s.[FileName] )
		WHEN NOT MATCHED By target THEN
			Insert([name],[file_stream])
			Values(s.[FileName],s.[Content]);

	 -- Merge for Attachment table
		MERGE CM.[CMAttachments] as t
		USING (
			Select 
				fat.Id As Id,
				@ProjectId As ProjectId,
				@ObjectName As ObjectName,
				@ObjectId As ObjectId,
				tft.[stream_id] As stream_id,
				tft.[creation_time] As CreatedDate,
				@UserId As CreatedUserId,
				0 As IsDelete,
				IIF(@IsUsed=0,0,1) AS IsUsed,
				fat.[CustomType] As CustomType,
				tft.[file_type] As FileType,
				fat.[FileName] As [FileName],
				fat.[Remark] As Remark
				From [GatePass].[ftAttachmentGatePass] tft
				JOIN @Files fat on fat.[FileName] = tft.[name]
		) s 

		ON (t.[Id] = s.[Id])

		WHEN NOT MATCHED By TARGET THEN 
			Insert(ProjectId,ObjectName,ObjectId,stream_id,CreatedDate,CreatedUserId,IsDelete,IsUsed,CustomType,FileType,[FileName],Remark)
			Values(s.ProjectId,s.ObjectName,s.ObjectId,s.stream_id,s.CreatedDate,s.CreatedUserId,s.IsDelete,s.IsUsed,s.CustomType,s.FileType,s.[FileName],s.Remark)
	
		WHEN NOT MATCHED BY SOURCE AND t.ObjectId = @ObjectId AND t.IsUsed = 0 THEN
			Update Set
				t.[IsDelete] = 1,
				t.[DeletedDate] = GETDATE(),
				t.[DeletedUserId] = @UserId,
				t.[DeletedOn] = t.[DeletedDate],
				t.[DeletedBy] = t.[DeletedUserId];		

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK;
		THROW
	END CATCH


END

GO
/****** Object:  StoredProcedure [GatePass].[SaveFaceIdentificationPlace]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[SaveFaceIdentificationPlace]
@ProjectId int,
@UserId int,
@Name nvarchar(50),
@EnName varchar(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		---- START CHECK ACL
		--DECLARE @HasAccess int
		--SET @HasAccess = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.SaveFaceIdentificationPlace')

		--IF @HasAccess IS NULL OR @HasAccess = 0
		--	THROW 50002,'you don''t have access for save opration on this form!',1
		---- END CHECK ACL


		INSERT INTO GatePass.FaceIdentificationPlace
		(
			[ProjectId],
			[Name],
			[EnName],
			[CreatedBy],
			[CreatedDate]

		)VALUES
		(
			@ProjectId,
			@Name,
			@EnName,
			@UserId,
			GETDATE()
		)
		COMMIT;
	END TRY
	BEGIN CATCH
		ROLLBACK;
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [GatePass].[SaveGatePassDetail]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[SaveGatePassDetail]
@ProjectId as int,
@UserId as int,
@ObjectId as int,
@CompanyId as int = NULL,
@Confirms as GatePass.ItemDetailType READONLY
AS
BEGIN

	BEGIN TRY
	BEGIN TRAN

	-- Get New Person Code From Config table
	DECLARE @PersonCodeConunter INT= 0;
	SELECT @PersonCodeConunter = [Value] FROM CM.CMConfig WHERE Scope = 'GatePass' AND Name = 'PersonCodeCounter' AND ProjectId = @ProjectId

	DECLARE @ObjectName varchar(55) 
	DECLARE @DocumentRole varchar(55)
	DECLARE @RoleOrder INT
	
	SELECT @ObjectName = [Type],@DocumentRole =  DocumentOwnersRole FROM CM.CMDocument WHERE Id= @ObjectId

	SELECT @RoleOrder = [Order] FROM CM.CMSignConfig 
	WHERE Role = @DocumentRole AND ObjectName = @ObjectName AND ProjectId = @ProjectId AND (@CompanyId = @CompanyId OR CompanyId IS NULL)

	-- Start Merge For GatePass detail Items  
		MERGE GatePass.GatePassDetail as t
			USING (
				SELECT * FROM @Confirms
			) s 

			ON (t.[GatePassId] = s.[GatePassId] AND t.DocumentId = s.ObjectId AND t.RoleOrder = @RoleOrder )

			WHEN NOT MATCHED By target THEN
				Insert(DocumentId,GatePassId,RoleOrder,Accept,CreatedBy,CreatedDate)
				Values(s.ObjectId,s.GatePassId,@RoleOrder,IIF(s.Accept IS NULL,0,s.Accept),@UserId,GETDATE())

			WHEN MATCHED THEN
				UPDATE Set
				Accept = IIF(s.Accept IS NULL,0,s.Accept),
				UpdatedBy = @UserId,
				UpdatedDate = GETDATE();
	-- End Merge For GatePassDetail Items


	IF @RoleOrder = 8
	BEGIN

		-- Set PersonCode IF Don't Have Person Code
		DECLARE @CurrentPersonCode VARCHAR(50);
		DECLARE @PersonContractId INT

		SELECT @CurrentPersonCode = pc.PersonCode,@PersonContractId = pc.Id FROM GatePass.PersonContract pc
		JOIN GatePass.GatePass gp ON gp.PersonContractId = pc.Id
		JOIN CM.CMDocument doc ON doc.Id = gp.DocumentId AND doc.ContractId = pc.ContractId
		WHERE doc.Id = @ObjectId

		DECLARE @AcceptedItem BIT = 0
		SELECT @AcceptedItem = Accept FROM @Confirms WHERE Accept = 1

		IF @AcceptedItem = 1 AND @CurrentPersonCode IS NULL BEGIN 
			UPDATE GatePass.PersonContract SET PersonCode = @PersonCodeConunter WHERE Id = @PersonContractId
			UPDATE CM.CMConfig SET [Value] = @PersonCodeConunter + 1 WHERE Scope = 'GatePass' AND Name = 'PersonCodeCounter' AND ProjectId = @ProjectId
		END

	END

	COMMIT

	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK;
		THROW
	END CATCH

END

GO
/****** Object:  StoredProcedure [GatePass].[SaveGatePassRequest]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [GatePass].[SaveGatePassRequest]
@ProjectId INT,
@ContractId INT,
@EmployerId INT,
@ContractorId INT,
@ObjectId int = NULL,
@UserId int,
@ObjectName varchar(55),
@ReportNoParameters VARCHAR(200),
@GatePassRequestTypeId INT,
@GatePassItem As GatePass.GatePassItems ReadOnly,
@DocumentId int output
As

BEGIN	
	Begin TRY
		Begin TRANSACTION

		--Declare Ongoin Table 
		DECLARE @Ongoing TABLE( ReportNo VARCHAR(200), Posted BIT, Accepted BIT, Complete BIT, PersonFullName NVARCHAR(120), NationalCode CHAR(10))
		DECLARE @OngoingDocument VARCHAR(200);

		DECLARE @ActiveGatePass TABLE(RowNumber INT,PreviousActiveGatePassId INT,DocumentId INT,GatePassId INT,PersonId INT,PersonContractId INT,EmployerId INT,ContractId INT,ContractorId INT,NationalCode CHAR(10),ExpireDate DATETIME,IsRevoke BIT,Complete BIT,Accepted BIT,Expired BIT,Employer NVARCHAR(200),Company NVARCHAR(200),Status BIT,PersonCode VARCHAR(50),PreviousGatePassExpDate DATETIME,PreviousGatePassEmployer NVARCHAR(200),PreviousGatePassCompany NVARCHAR(200),PreviousPersonCode VARCHAR(50))
		DECLARE @HasActiveGatePass INT = 0;


		DECLARE @ErrorMessage NVARCHAR(500);

		DECLARE @ExpDate DATETIME;
		DECLARE @DisciplineId INT;

		DECLARE @Counter INT = 0;
		DECLARE @ItemsLength INT = 0;

		SELECT @ItemsLength =  COUNT(*) FROM @GatePassItem

		DECLARE @PersonContractId INT;
		DECLARE @NationalCode CHAR(10);
		DECLARE @ItemGatePassRequestTypeId INT;

		-- Check ALL Statement row by row here
		WHILE @Counter < @ItemsLength
		BEGIN

		SET @ErrorMessage = NULL;

		-- Set Variables
		SELECT @NationalCode = NationalCode,@PersonContractId = PersonContractId,@ItemGatePassRequestTypeId = @GatePassrequestTypeId FROM @GatePassItem WHERE [CounterId] = @Counter
		
		-- Check pitem request not mach by gatePass Document request
		IF @ItemGatePassRequestTypeId <> @GatePassRequestTypeId
		BEGIN
			SET @ErrorMessage = 'The person with '+@NationalCode+' GatePassRequest type not match with document request!\nدرخواست فرد مورد نظر با نوع درخواست با سند منطبق نمی باشد.'
		 ;THROW 50002,@ErrorMessage,1
		END
		-- Check has Ongoing Document
		INSERT INTO @Ongoing(ReportNo, Posted, Accepted, Complete, PersonFullName, NationalCode)
		EXEC GatePass.FetchOngoingPersonDocument
		    @ProjectId=@ProjectId, -- int
			@ContractId=@ContractId, -- int
		    @NationalCode=@nationalCode -- char(10)

		SELECT TOP(1) @OngoingDocument = ReportNo FROM @Ongoing
		
		IF @OngoingDocument IS NOT NULL 
		BEGIN 
		SET @ErrorMessage = 'Item has onoing document by '+@OngoingDocument+' report number!';
		THROW 50003,@ErrorMessage,1

		END

		 --Chepck has active gatepass
		INSERT INTO @ActiveGatePass(RowNumber, PreviousActiveGatePassId, DocumentId, GatePassId, PersonId, PersonContractId,ContractId, EmployerId, ContractorId, NationalCode, ExpireDate, IsRevoke, Complete, Accepted, Expired, Employer, Company, Status, PersonCode, PreviousGatePassExpDate, PreviousGatePassEmployer, PreviousGatePassCompany, PreviousPersonCode)
		EXEC GatePass.FetchActiveGatePassByPersonContractId
			 @ProjectId=@ProjectId, -- int
		     @PersonContractId=@PersonContractId -- int
		
		SELECT @HasActiveGatePass = COUNT(*) FROM @ActiveGatePass

		IF @HasActiveGatePass > 0  AND @ItemGatePassRequestTypeId = 0
		BEGIN
			SET @ErrorMessage = 'The person with '+@NationalCode+' national code has active gatepass\nفرد مورد گیت پاس فعال در سیستم دارد و شما باید مسیر درخواست گیت پاس تمدیدی رو دنبال کنید'
			;THROW 50004,@ErrorMessage,1;
		END

		IF @HasActiveGatePass = 0  AND @ItemGatePassRequestTypeId = 1
		BEGIN
			SET @ErrorMessage = 'The person with '+@NationalCode+' national don''t have any active gatepass, you must select new type\nفرد مورد نظر گیت پاس فعالی در سیستم ندارد بنابراین می بایست حتما نوع درخواست را بصور گیت پاس جدید ایجاد نمائید.'
			;THROW 50004,@ErrorMessage,1;
		END

		--Check request not in the black list here


		SET @Counter = @Counter + 1;
		END

		-- Select DisciplineId 
		SELECT @DisciplineId = CAST(Value AS INT) FROM CM.CMConfig WHERE ProjectId = @ProjectId AND Scope = 'GatePass' AND Name = 'DisciplineId'

					
		Select @ExpDate = DATEADD(DAY,gp.AttendanceDuration,gp.AttendanceDate) From CM.CMDocument doc
		JOIN GatePass.GatePass gp On gp.DocumentId = doc.Id
		JOIN GatePass.GatePassDetail gpd ON gpd.GatePassId = gp.Id AND gpd.Accept = 1 AND gpd.RoleOrder = 5
		JOIN GatePass.Person emp On emp.Id = gp.PersonContractId
		WHERE doc.IsDelete = 0 AND doc.IsVoid = 0 AND gp.IsDelete = 0 AND gp.IsRevoke = 0	
			 
		DECLARE	@ReportNo varchar(255),@CounterId int

     	EXEC [CM].[GenerateReportNumber]
			@ProjectId = @ProjectId,
			@ObjectName = @ObjectName,
			@Parameters = @ReportNoParameters,
			@CounterId = @CounterId OUTPUT,
			@ReportNumber = @ReportNo OUTPUT

		DECLARE @IsDelete bit,@IsVoid bit,@Posted bit

		IF @ObjectId IS NULL
			BEGIN 
				DECLARE @Identity INT;
				EXEC CM.CreateDocument 
				@ProjectId = @ProjectId, 
				@ContractId = @ContractId, 
				@CompanyId = @EmployerId, 
				@ContractorId = @ContractorId, 
				@ReportNo = @ReportNo,
				@CreatedBy = @UserId,
				@Type='GatePass',
				@DisciplineId=@DisciplineId,
				@Identity=@Identity OUTPUT
				SET @DocumentId = @Identity			
			END	
		ELSE
			BEGIN
				SET @DocumentId = @ObjectId
				SELECT @Posted = Posted,@IsVoid = IsVoid,@IsDelete = IsDelete FROM CM.CMDocument WHERE Id = @ObjectId
				IF @IsVoid = 1 OR @IsDelete = 1
					BEGIN 					
						IF @IsVoid = 1 
							THROW 50003,'Can not update update document because document IsVoided!',1

						IF @IsDelete = 1
							THROW 50004,'Can not update update document because document IsDelete!',1
					END		

				UPDATE CM.CMDocument SET
					CompanyId = @EmployerId,
					ModifiedBy = @UserId,
					ModifiedOn = GETDATE()	
			END
					
	    -- Merge Start
		MERGE GatePass.GatePass as t
		USING (
			SELECT Id,PersonContractId,RequestTypeId,UnitRequestId,Unit,AttendanceDate,AttendanceDuration,GatePassTypeId,JobPositionId,JobPosition,[Remark] 
			FROM @GatePassItem			
		) s 

		ON (t.[Id] = s.[Id] )

		WHEN NOT MATCHED By target THEN
			Insert(DocumentId,PersonContractId,RequestTypeId,UnitRequestId,Unit,AttendanceDate,AttendanceDuration,GatePassTypeId,JobPositionId,JobPosition,[Description],CreatedBy,CreatedDate)
			Values(@DocumentId,s.PersonContractId,s.RequestTypeId,s.UnitRequestId,s.Unit,s.AttendanceDate,s.AttendanceDuration,s.GatePassTypeId,s.JobpositionId,s.JobPosition,s.[Remark],@UserId,GETDATE())

		WHEN MATCHED THEN
			UPDATE Set
			t.PersonContractId = s.PersonContractId,
			t.RequestTypeId = s.RequestTypeId,
			t.UnitRequestId = s.UnitRequestId,
			t.Unit = s.Unit,
			t.AttendanceDate = s.AttendanceDate,
			t.AttendanceDuration = s.AttendanceDuration,
			t.GatePassTypeId = s.GatePassTypeId,
			t.JobPositionId = s.JobPositionId,
			t.JobPosition = s.JobPosition,
			t.[Description] = s.[Remark],
			t.UpdatedBy	= @UserId,
			t.UpdatedDate = GETDATE()
	
		WHEN NOT MATCHED BY SOURCE And t.DocumentId = @ObjectId THEN
			Update Set
				t.[IsDelete] = 1,
				t.DeletedBy = @UserId,
				t.DeletedDate = GETDATE();
	    -- Merge End		

	    -- Merge For GatePass.Attachemnt
		MERGE GatePass.Attachment as t
		USING (
				SELECT gp.DocumentId,gp.Id As GatePassId,cmatt.Id AS AttachmentId,pc.Id AS PersonContractId FROM CM.CMAttachments cmatt
				JOIN GatePass.PersonContract pc ON pc.Id = cmatt.ObjectId
				JOIN GatePass.GatePass gp ON gp.PersonContractId = pc.Id								
				WHERE cmatt.ProjectId = @ProjectId And cmatt.ObjectName = 'GatePass' And cmatt.IsDelete = 0
		) s 

		ON (t.[GatePassId] = s.[GatePassId] And t.DocumentId = s.DocumentId )

		WHEN NOT MATCHED By target THEN
			Insert(DocumentId,GatePassId,AttachmentId,PersonContractId,CreatedBy,CreatedDate)
			Values(s.DocumentId,s.GatePassId,s.AttachmentId,s.PersonContractId,@UserId,GETDATE())
	
		WHEN NOT MATCHED BY SOURCE THEN
			Update Set
			t.UpdatedBy = @UserId,
			t.UpdatedDate = GETDATE(),
			t.IsDelete = 1;			
	    -- End Merge For GatePass Attachments			
				
		EXEC CM.IncrementReportNumber @CounterId = @CounterId
											
		COMMIT;

	End TRY
	Begin CATCH		
		RollBack;
		Throw;
	End CATCH

END



GO
/****** Object:  StoredProcedure [GatePass].[SaveGatePassType]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[SaveGatePassType]
@ProjectId int,
@UserId int,
@Name nvarchar(50),
@EnName varchar(50),
@Color varchar(50)

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		---- START CHECK ACL
		--DECLARE @HasAccess int
		--SET @HasAccess = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.SaveGatePassType')

		--IF @HasAccess IS NULL OR @HasAccess = 0
		--	THROW 50002,'you don''t have access for save opration on this form!',1
		---- END CHECK ACL


		INSERT INTO GatePass.GatePassType
		(
			[ProjectId],
			[Name],
			[EnName],
			[Color],
			[CreatedBy],
			[CreatedDate]

		)VALUES
		(
			@ProjectId,
			@Name,
			@EnName,
			@Color,
			@UserId,
			GETDATE()
		)
		COMMIT;
	END TRY
	BEGIN CATCH
		ROLLBACK;
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [GatePass].[SavePerson]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[SavePerson]
@ProjectId int,
@ContractId INT,
@UserId int,
@ObjectName varchar(50),
@NationalId char(10),
@FirstName nvarchar(50),
@LastName nvarchar(50),
@FatherName nvarchar(50),
@EnFirstName varchar(50),
@EnLastName varchar(50),
@EnFatherName varchar(50),
@GenderId int,
@NativeCode INT,
@BcNumber varchar(10),
@BirthDate date,
@BirthCityId int,
@IssuanceCityId int,
@FatherBirthCityId int,
@MotherBirthCityId int,
@UnitId int,
@JobPositionId int,
@Identifier varchar(200),
@MobileNo VARCHAR(14),
@PhoneNo VARCHAR(20),
@TrackingCode varchar(200),
@FaceIdPlaceIds CM.IdsTable ReadOnly,
@Address NVARCHAR(200),
@Files as CM.FileItemType ReadOnly,
@PersonId int output

AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		-- بررس میشود که ایا این شخص عضو یک کمپانی و بصورت کامل فعال میباشد یا خیر
		DECLARE @PersonStatus BIT = 0;
        
		SELECT TOP (1) @PersonStatus = pc.[Status] FROM GatePass.PersonContract pc
		INNER JOIN GatePass.Person p ON p.Id = pc.PersonId
		WHERE pc.ContractId = @ContractId AND p.NationalCode = @NationalId ORDER BY pc.Id DESC
	
		-- چنانچه فعال است امکان ثبت جود ندارد
		IF @PersonStatus = 1
			THROW 50002,'National Id already exist in the database!',1
		
		UPDATE CM.City SET NationalCode = 
		CASE
			WHEN NationalCode IS NULL THEN LEFT(@NationalId,3)
			WHEN NationalCode IS NOT NULL THEN CONCAT(NationalCode,',',LEFT(@NationalId,3))
		END
		WHERE Id = @IssuanceCityId AND (NationalCode NOT like '%'+LEFT(@NationalId,3)+'%' OR NationalCode IS NULL)

		INSERT INTO GatePass.Person
		(
			[ProjectId],			
			[FirstName],
			[LastName],
			[FatherName],
			[EnFirstName],
			[EnLastName],
			[EnFatherName],
			[GenderId],
			[NativeCode],
			[NationalCode],
			[CardCode],
			[BirthDate],
			[BirthCityId],
			[CardIssuanceCityId],
			[FatherBirthCityId],
			[MotherBirthCityId],
			UnitId,
			JobPositionId,
			Identifier,
			MobileNo,
			PhoneNo,
			[TrackingCode],
			[Address],
			[CreatedBy],
			[CreateDate]			

		) VALUES
		(
			@ProjectId,
			@FirstName,
			@LastName,
			@FatherName,
			@EnFirstName,
			@EnLastName,
			@EnFatherName,
			@GenderId,
			@NativeCode,
			@NationalId,
			@BcNumber,
			@BirthDate,
			@BirthCityId,
			@IssuanceCityId,
			@FatherBirthCityId,
			@MotherBirthCityId,
			@UnitId,
			@JobPositionId,
			@Identifier,
			@MobileNo,
			@PhoneNo,
			@TrackingCode,
			@Address,
			@UserId,
			GETDATE()
		)
		

		SET @PersonId = SCOPE_IDENTITY()


		INSERT INTO GatePass.PersonContract(PersonId, ContractId, PersonCode, Status)
			VALUES(@PersonId, @ContractId, NULL, DEFAULT)

		DECLARE @PersonContractId INT;
		SET @PersonContractId = SCOPE_IDENTITY()

		-- Merge for FaceId
		EXEC GatePass.SavePersonFaceIdPlaces
			@EmployeeId=@PersonId, -- int
		    @UserId=@UserId, -- int
		    @FaceIdPlaceIds=@FaceIdPlaceIds -- IdsTable
					
		-- End Merge for FaceId

		EXEC GatePass.SaveAttachment 
			@ProjectId=@ProjectId,
		    @UserId=@UserId,
		    @ObjectName=@ObjectName,
		    @ObjectId= @PersonContractId,
		    @IsUsed=0,
		    @Files=@Files		
		COMMIT	
	END TRY
	BEGIN CATCH
		ROLLBACK;
		IF ERROR_NUMBER() = 2627
			THROW 50001,'National Id already exist in the database!',1
		;THROW
	END CATCH
END

GO
/****** Object:  StoredProcedure [GatePass].[SavePersonFaceIdPlaces]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[SavePersonFaceIdPlaces]
@EmployeeId int,
@UserId int,
@FaceIdPlaceIds CM.IdsTable READONLY
AS
BEGIN
-- Merge for FaceId
		MERGE GatePass.PersonFaceIdentification as t
		USING (
			Select Id FROM @FaceIdPlaceIds				
		) s 

		ON (t.[FaceIdentificationId] = s.[Id] AND t.EmployeeId = @EmployeeId )

		WHEN NOT MATCHED  By target THEN
			Insert(FaceIdentificationId,EmployeeId,CreatedBy,CreatedDate)
			Values(s.[Id],@EmployeeId,@UserId,GETDATE())
			
		WHEN NOT MATCHED BY SOURCE AND t.EmployeeId = @EmployeeId THEN
			Delete;					
		-- End Merge for FaceId
END

GO
/****** Object:  StoredProcedure [GatePass].[SaveSatisfactionLetter]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[SaveSatisfactionLetter]
@ProjectId INT,
@ContractId INT,
@EmployerId INT,
@ContractorId INT,
@PersonId INT,
@ObjectId INT = NULL,
@UserId int,
@ObjectName varchar(55),
@ReportNoParameters VARCHAR(200) = NULL,
@Remark NVARCHAR(500),
@SignRemark NVARCHAR(500),
@SaveAndPost BIT = 0,
@Files as CM.FileItemType ReadOnly,
@MachineName NVARCHAR(100),
@ActiveDirectoryName NVARCHAR(100),
@DocumentId int output
AS
BEGIN

	BEGIN TRY
		BEGIN TRAN
	
		DECLARE @DisciplineId INT;
		SELECT @DisciplineId = [value] FROM CM.Config WHERE  ProjectId = @ProjectId AND Scope = 'GatePass' AND [Name] = 'DisciplineId'

		IF @ObjectId IS NULL
			BEGIN

				DECLARE @ReportNumber VARCHAR(100)
				DECLARE @ErrorMessage VARCHAR(100)
				SELECT @ReportNumber = doc.ReportNo FROM GatePass.LetterRequest ltr
				JOIN CM.CMDocument doc ON doc.Id = ltr.DocumentId
				WHERE ltr.PersonId =@PersonId AND doc.Complete = 0
				SET @ErrorMessage = 'The selected person has ongoing letter document : ' + @ReportNumber
				IF @ReportNumber IS NOT NULL THROW 50005,@ErrorMessage,1



				DECLARE	@ReportNo varchar(255),@CounterId INT
        
				DECLARE @ReportSyntaxObjectName VARCHAR(80)
				SET @ReportSyntaxObjectName = CONCAT(@ObjectName,'.Letter');

     			EXEC [CM].[GenerateReportNumber]
					@ProjectId = @ProjectId,
					@ObjectName = @ReportSyntaxObjectName,
					@Parameters = @ReportNoParameters,
					@CounterId = @CounterId OUTPUT,
					@ReportNumber = @ReportNo OUTPUT

				EXEC CM.IncrementReportNumber @CounterId = @CounterId


				DECLARE @Identity INT;
				EXEC CM.CreateDocument
					@ProjectId=@ProjectId,
					@ReportNo=@ReportNo,
					@CreatedBy=@UserId,
					@CompanyId=@EmployerId,
					@Type=@ObjectName,
					@DisciplineId=@DisciplineId,
					@Type2='Letter', 
					@Remark=@Remark,
					@Identity=@Identity OUTPUT,
					@ContractId=@ContractId,
					@ContractorId=@ContractorId

				SET @DocumentId = @Identity

				INSERT INTO GatePass.LetterRequest(DocumentId, PersonId, CreatedBy, CreatedDate)
					VALUES(
					@DocumentId,
					@PersonId,
					@UserId,
					GETDATE()
				)	

			END
		ELSE
			BEGIN
				SET @DocumentId = @ObjectId
				UPDATE CM.CMDocument SET
					ModifiedOn = GETDATE(),
					ModifiedBy= @UserId,
					ContractId = @ContractId,
					CompanyId = @EmployerId,				
					ContractorId = @ContractorId,
					Remark = @Remark
				WHERE Id = @ObjectId
				
				UPDATE GatePass.LetterRequest SET
					PersonId = @PersonId,
					UpdatedBy = @UserId,
					UpdatedDate = GETDATE()
				WHERE DocumentId = @ObjectId

			END

		EXEC GatePass.SaveAttachment 
			@ProjectId=@ProjectId, -- int
		    @UserId=@userId, -- int
		    @ObjectName=@ObjectName, -- nvarchar(255)
		    @ObjectId=@DocumentId, -- int
		    @IsUsed=0, -- bit
		    @Files=@Files -- FileItemType
		



		IF @SaveAndPost = 1
			BEGIN
				EXEC GatePass.SignLetterDocument 
					@SignRequestType='POST', -- varchar(55)
					@ProjectId=@ProjectId, -- int
					@UserId=@UserId, -- int
					@ObjectId=@DocumentId, -- int
					@Remark=@SignRemark, -- nvarchar(2000)
					@NextRole='', -- varchar(50)
					@NextRoleUsersId='', -- varchar(200)
					@AclCanDynamicRoleName='', -- varchar(55)
					@MachineName=@MachineName, -- nvarchar(150)
					@ActiveDirectoryName=@ActiveDirectoryName -- nvarchar(250)
			END


		COMMIT
	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK;
		THROW;
	END CATCH
		
END

GO
/****** Object:  StoredProcedure [GatePass].[SaveSettings]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[SaveSettings]
@ProjectId int,
@Rows As GatePass.[SettingsItemsType]  ReadOnly
AS
BEGIN
	Begin TRY
		Begin Transaction
	  --Merge for FileTicketAttachment table
	  MERGE GatePass.Settings as t
		USING @Rows As s 
		ON (t.Id = s.Id )
		WHEN NOT MATCHED By target THEN
			Insert([ProjectId],[CompanyId],[Name],[Value])
			Values(@projectId,s.[Company],s.[Name],s.[Value])

		WHEN MATCHED THEN
			UPDATE Set
			[ProjectId] = @ProjectId,
			[CompanyId] = s.Company,
			[Name] = s.[Name],
			[Value] = s.[Value];
								
		COMMIT
	END TRY
	BEGIN CATCH		
		ROLLBACK
	END CATCH










END

GO
/****** Object:  StoredProcedure [GatePass].[SignDocument]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[SignDocument]
	@SignRequestType varchar(55),
	@ProjectId as int,
	@UserId as int,
	@ObjectId as int,
	@Remark as nvarchar(2000) = NULL,
	@NextRole as varchar(50) = NULL,
	@NextRoleUsersId  varchar(200) = NULL,
	@AclCanDynamicRoleName varchar(55) = NULL,
	@MachineName as nvarchar(150) = NULL,
	@ActiveDirectoryName as nvarchar(250) = NULL,
	@LoggedUserId as int = NULL,
	@CompanyId as int = NULL,
	@Confirms as GatePass.ItemDetailType READONLY
AS
BEGIN

	BEGIN TRY
	BEGIN TRAN

	DECLARE @ObjectName varchar(55) 
	DECLARE @DocumentRole varchar(55)
	DECLARE @RoleOrder int

	SELECT @ObjectName = [Type],@DocumentRole =  DocumentOwnersRole FROM CM.CMDocument WHERE Id= @ObjectId

	SELECT @RoleOrder = [Order] FROM CM.CMSignConfig 
	WHERE Role = @DocumentRole AND ObjectName = @ObjectName AND ProjectId = @ProjectId AND (@CompanyId = @CompanyId OR CompanyId IS NULL)


	DECLARE @CountAcceptedItems INT = 0
	SELECT @CountAcceptedItems = COUNT(*) FROM @Confirms act
	WHERE act.Accept = 1

	IF @RoleOrder = 8 AND  @CountAcceptedItems > 0 AND @SignRequestType = 'Reject' THROW 50002,'The document accepted item can not reject it!',1
	
	-- Confirm For HR And GatePassIssuer
	IF @RoleOrder = 5 OR @RoleOrder = 6 OR @RoleOrder = 8
	BEGIN	
		-- Start Confirmation Section For HR And GatePassIssuer
		EXEC GatePass.SaveGatePassDetail
			@ProjectId = @ProjectId,
			@UserId = @UserId,
			@ObjectId = @ObjectId,
			@CompanyId = @CompanyId,
			@Confirms = @Confirms
	END

		
	--Update relationed attachmentt
	UPDATE CM.CMAttachments  		
	SET IsUsed = 1					
	WHERE ObjectId IN (SELECT [gatt].PersonContractId FROM GatePass.Attachment gatt
	JOIN CM.CMAttachments cmatt ON cmatt.Id = gatt.AttachmentId
	JOIN CM.CMDocument doc On doc.Id = gatt.DocumentId
	WHERE gatt.DocumentId = @ObjectId AND doc.Posted = 0)
	
		
	
	EXEC SGN.SignDocument
		@SignRequestType = @SignRequestType,
		@ProjectId = @ProjectId,
		@UserId = @UserId,
		@ObjectName = @ObjectName,
		@SignConfigObjectName = @ObjectName,
		@ObjectId = @ObjectId,
		@Remark = @Remark,
		@NextRole = @NextRole,
		@NextRoleUsersId = @NextRoleUsersId,
		@AclCanDynamicRoleName = @AclCanDynamicRoleName,
		@MachineName = @MachineName,
		@ActiveDirectoryName = @ActiveDirectoryName,
		@LoggedUserId = @LoggedUserId,
		@CompanyId = @CompanyId

		COMMIT;
	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT> 0 ROLLBACK
	;THROW

	END CATCH

END
GO
/****** Object:  StoredProcedure [GatePass].[SignLetterDocument]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[SignLetterDocument]
	@SignRequestType varchar(55),
	@ProjectId as int,
	@UserId as int,
	@ObjectId as int,
	@Remark as nvarchar(2000) = NULL,
	@NextRole as varchar(50) = NULL,
	@NextRoleUsersId  varchar(200) = NULL,
	@AclCanDynamicRoleName varchar(55) = NULL,
	@MachineName as nvarchar(150) = NULL,
	@ActiveDirectoryName as nvarchar(250) = NULL,
	@LoggedUserId as int = NULL,
	@CompanyId as int = NULL
AS
BEGIN

	BEGIN TRY
	BEGIN TRAN

	DECLARE @ObjectName varchar(55) 
	DECLARE @SignConfigObjectName varchar(55) 
	DECLARE @DocumentRole varchar(55)

	SELECT @ObjectName = Type,@SignConfigObjectName = CONCAT(Type,'.',Type2),@DocumentRole =  DocumentOwnersRole FROM CM.CMDocument WHERE Id= @ObjectId

		
	EXEC SGN.SignDocument
		@SignRequestType = @SignRequestType,
		@ProjectId = @ProjectId,
		@UserId = @UserId,
		@ObjectName = @ObjectName,
		@SignConfigObjectName = @SignConfigObjectName,
		@ObjectId = @ObjectId,
		@Remark = @Remark,
		@NextRole = @NextRole,
		@NextRoleUsersId = @NextRoleUsersId,
		@AclCanDynamicRoleName = @AclCanDynamicRoleName,
		@MachineName = @MachineName,
		@ActiveDirectoryName = @ActiveDirectoryName,
		@LoggedUserId = @LoggedUserId,
		@CompanyId = @CompanyId

	DECLARE @PersonId INT
	SELECT @PersonId = lr.PersonId FROM GatePass.PersonContract pc
		JOIN GatePass.LetterRequest lr ON lr.PersonId = pc.PersonId
		WHERE lr.DocumentId = @ObjectId

	DECLARE @DocumentAccepted BIT
    SELECT @DocumentAccepted = Accepted FROM CM.CMDocument WHERE Id =@ObjectId AND Complete = 1

	IF @DocumentAccepted = 1
	 BEGIN 
		UPDATE GatePass.PersonContract SET
			Status = 0
		WHERE PersonId = @PersonId	

		EXEC GatePass.RevokeGatePasses
			@ProjectId = @ProjectId, -- int
			@UserId= @UserId, -- int
			@PersonId = @PersonId -- char(10)

	 END
		COMMIT;
	END TRY

	BEGIN CATCH
	ROLLBACK
	;THROW

	END CATCH

END
GO
/****** Object:  StoredProcedure [GatePass].[UpdateFaceIdentificationPlace]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [GatePass].[UpdateFaceIdentificationPlace]
@Id int,
@ProjectId int,
@UserId int,
@Name nvarchar(50),
@EnName varchar(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		---- START CHECK ACL
		--DECLARE @HasAccess int
		--SET @HasAccess = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.UpdateFaceIdentificationPlace')

		--IF @HasAccess IS NULL OR @HasAccess = 0
		--	THROW 50002,'you don''t have access for save opration on this form!',1
		---- END CHECK ACL


		UPDATE GatePass.FaceIdentificationPlace SET
			[Name] = @Name,
			[EnName] = @EnName,
			[UpdatedBy] = @UserId,
			[UpdatedDate] = GETDATE()
		WHERE Id = @Id AND ProjectId = @ProjectId

		COMMIT;
	END TRY
	BEGIN CATCH
		ROLLBACK;
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [GatePass].[UpdateGatePassType]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [GatePass].[UpdateGatePassType]
@Id int,
@ProjectId int,
@UserId int,
@Name nvarchar(50),
@EnName varchar(50),
@Color varchar(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		---- START CHECK ACL
		--DECLARE @HasAccess int
		--SET @HasAccess = SGN.FnUserHasAcl(@ProjectId,@UserId,'GatePass.UpdateGatePassType')

		--IF @HasAccess IS NULL OR @HasAccess = 0
		--	THROW 50002,'you don''t have access for save opration on this form!',1
		---- END CHECK ACL


		UPDATE GatePass.GatePassType SET
			[Name] = @Name,
			[EnName] = @EnName,
			[Color] = @Color,
			[UpdatedBy] = @UserId,
			[UpdatedDate] = GETDATE()
		WHERE Id = @Id AND ProjectId = @ProjectId

		COMMIT;
	END TRY
	BEGIN CATCH
		ROLLBACK;
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [GatePass].[UpdateJobPositionAndAttendanceDuration]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[UpdateJobPositionAndAttendanceDuration]
@ProjectId INT,
@UserId INT,
@PersonContractId INT,
@GatePassId INT,
@DocumentId INT,
@RoleId INT = NULL,
@AttendanceDuration_S INT = NULL,
@AttendanceDuration INT = NULL,
@JobPositionId_S INT = NULL,
@JobPositionId INT = NULL,
@JobPosition_S NVARCHAR(100) = NULL,
@JobPosition NVARCHAR(100) = NULL
AS
BEGIN
	
	BEGIN TRY
	BEGIN TRAN

	-- Create History For Person Job Position		
	INSERT INTO GatePass.PersonHistory 
	(
		ProjectId,
		RoleId,
		JobPositionId_S,
		JobPositionId,
		JobPosition_S,
		JobPosition,
		CreatedBy,
		CreatedDate
	)
	VALUES
	(
		@ProjectId,
		@RoleId,
		@JobPositionId_S,
		@JobPositionId,
		@JobPosition_S,
		@JobPosition,
		@UserId,
		GETDATE()
	)

	-- Create History For GatePass Request

	INSERT INTO GatePass.GatePassRequestHistory 
	(
		ProjectId,
		RoleId,
		AttendanceDuration_S,
		AttendanceDuration,
		CreatedBy,
		CreatedDate
	)
	VALUES
	(
		@ProjectId,
		@RoleId,
		@AttendanceDuration_S,
		@AttendanceDuration,
		@UserId,
		GETDATE()
	)

	COMMIT;
	END TRY
	BEGIN CATCH
	IF @@TRANCOUNT > 0 ROLLBACK;
	THROW;

	END CATCH

END

GO
/****** Object:  StoredProcedure [GatePass].[UpdatePerson]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GatePass].[UpdatePerson]
@Id int,
@ProjectId int,
@ContractId int,
@UserId int,
@ObjectName varchar(50),
@NationalId char(10),
@FirstName nvarchar(50),
@LastName nvarchar(50),
@FatherName nvarchar(50),
@EnFirstName varchar(50),
@EnLastName varchar(50),
@EnFatherName varchar(50),
@GenderId INT,
@NativeCode INT,
@BcNumber varchar(10),
@BirthDate date,
@BirthCityId int,
@IssuanceCityId int,
@FatherBirthCityId int,
@MotherBirthCityId int,
@UnitId int,
@JobPositionId int,
@Identifier varchar(200),
@MobileNo VARCHAR(14),
@PhoneNo VARCHAR(20),
@TrackingCode varchar(200),
@FaceIdPlaceIds CM.IdsTable ReadOnly,
@Address NVARCHAR(200),
@Files as CM.FileItemType ReadOnly,
@PersonId int output

AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION


		--DECLARE TEMP TABLE
		DECLARE @OngoingRequestTable TABLE(ReportNo VARCHAR(100),Posted BIT,Accepted BIT,Complete BIT,Person NVARCHAR(155),NationalCode CHAR(10))

		DECLARE @PersonStatus BIT = 0;
        
		SELECT TOP (1) @PersonStatus = pc.[Status] FROM GatePass.PersonContract pc
		WHERE pc.PersonId = @Id AND pc.Status = 1 AND pc.PersonCode IS NOT NULL ORDER BY pc.Id

		-- Select OnGoing GatePass ---------------------
		INSERT INTO @OngoingRequestTable
		EXEC GatePass.FetchOngoingPersonDocument 
			@ProjectId=0,
			@ContractId = @ContractId,
		    @NationalCode=@NationalId

		;DECLARE @Ongoing BIT
		Select @Ongoing = IIF(COUNT(*)>0,1,0) FROM @OngoingRequestTable; 


		UPDATE GatePass.Person SET
			[FirstName] = @FirstName,
			[LastName] = @LastName,
			[FatherName] = @FatherName,
			[EnFirstName] = @EnFirstName,
			[EnLastName] = @EnLastName,
			[EnFatherName] = @EnFatherName,
			[GenderId] = @GenderId,
			[NativeCode] = @NativeCode,
			[NationalCode] = @NationalId,
			[CardCode] = @BcNumber,
			[BirthDate] = @BirthDate,
			[BirthCityId] = @BirthCityId,
			[CardIssuanceCityId] = @IssuanceCityId,
			[FatherBirthCityId] = @FatherBirthCityId,
			[MotherBirthCityId] = @MotherBirthCityId,
			[UnitId] = IIF(@Ongoing=1,[UnitId],@UnitId),
			[JobPositionId] = IIF(@Ongoing=1,[JobPositionId],@JobPositionId),
			[Identifier] = @Identifier,
			[MobileNo] = @MobileNo,
			[PhoneNo] = @PhoneNo,
			[TrackingCode] = @TrackingCode,
			[Address] = @Address,
			[UpdatedBy] = @UserId,
			[UpdatedDate] = GETDATE()	
		
		WHERE Id = @Id
		
		SET @PersonId = @Id	


		DECLARE @PersonContractId INT;
		DECLARE @FileCount INT;

		-- Check File Attachment Count
		SELECT @FileCount = COUNT(*) FROM @Files
		IF @PersonStatus = 0
			BEGIN
			
				UPDATE GatePass.PersonContract 
				SET Status = 0
				WHERE PersonId = @PersonId
										
				IF(@FileCount<=0) THROW 500015,'Attachment required!',1;
				INSERT INTO GatePass.PersonContract(PersonId, ContractId, PersonCode, Status)
				VALUES(@PersonId, @ContractId, NULL, DEFAULT)
				SET @PersonContractId = SCOPE_IDENTITY();
			END
		ELSE
			BEGIN
				SELECT TOP (1) @PersonContractId = Id FROM GatePass.PersonContract WHERE ContractId = @ContractId AND PersonId = @PersonId ORDER BY Id DESC 
			END
				

		-- Merge for FaceId
		exec GatePass.SavePersonFaceIdPlaces
		 @EmployeeId = @PersonId,
		 @UserId = @UserId,
		 @FaceIdPlaceIds = @FaceIdPlaceIds				
		
		-- End Merge for FaceId			
		exec GatePass.SaveAttachment 
			@ProjectId = @ProjectId,
			@UserId = @UserId,
			@ObjectName = @ObjectName,
			@ObjectId = @PersonContractId,
			@Files = @Files

		COMMIT		
	END TRY
	BEGIN CATCH
		ROLLBACK;
		IF ERROR_NUMBER() = 2627
			THROW 50001,'National Id already exist in the database!',1
		;THROW
	END CATCH
END

GO
/****** Object:  StoredProcedure [JobReport].[CreateJobReport]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [JobReport].[CreateJobReport]

@ReportNumber varchar(200),
@ObjectName varchar(55),
@ProjectId int,
@DisciplineId int,
@CompanyId int,
@CreatedBy int,
@ReportDate DateTime,
@UserEmail NVARCHAR(MAX),
@ReportContent NVARCHAR(MAX),
@ProblemsContent NVARCHAR(MAX),
@Suggestion NVARCHAR(MAX),
@Files as JobReport.FileItemType ReadOnly,
@DocumentId int output


AS
BEGIN
	
	Begin TRY
		Begin Transaction

		DECLARE @Type2 varchar(55)

		DECLARE @HasAcl_Expert_To_Head bit = 0
		SET @HasAcl_Expert_To_Head = SGN.FnUserHasAcl(@ProjectId,@CreatedBy,CONCAT(@ObjectName,'.','Expert_To_Head'))

		DECLARE @HasAcl_Head_To_Manager bit = 0
		SET @HasAcl_Head_To_Manager = SGN.FnUserHasAcl(@ProjectId,@CreatedBy,CONCAT(@ObjectName,'.','Head_To_Manager'))

		IF @HasAcl_Expert_To_Head = 1 AND @HasAcl_Head_To_Manager = 1
		THROW 50001,'Can not have role ''Expert_To_Head'' and ''Head_To_Manager'' at same time!',1  

		IF @HasAcl_Expert_To_Head = 1
			Set @Type2 = 'Expert_Head'

		IF @HasAcl_Head_To_Manager = 1
			Set @Type2 = 'Head_Manager'


		Declare @ObjectId int;
		
		exec CM.CreateDocument @ProjectId,@ReportNumber,@CreatedBy,@CompanyId,@ObjectName,@DisciplineId,@Type2,NULL,@ObjectId OUTPUT

		SET @DocumentId = @ObjectId

		exec JobReport.SaveAttachment @ProjectId,@CreatedBy,@ObjectName,@ObjectId,@Files


		DECLARE @Now DateTime = GETDATE();

		
		INSERT [JobReport].JobReport(
			[ReportNumber],
			[ObjectId],
			[ProjectId],
			[DisciplineId],
			[CompanyId],
			[CreatedBy],
			[CreatedDate],
			[UpdatedBy],
			[UpdatedDate],
			[ReportDate],
			[UserEmail],
			[ReportContent],
			[ProblemsContent],
			[Suggestion]
		)
		VALUES(
			@ReportNumber,
			@ObjectId,
			@ProjectId,
			@DisciplineId,
			@CompanyId,
			@CreatedBy,
			@Now,
			@CreatedBy,
			@Now,
			@ReportDate,
			@UserEmail,
			@ReportContent,
			@ProblemsContent,
			@Suggestion		
		)
			
			
			
		--IF @PostOnSave = 1
		--	BEGIN
		--	EXEC SGn.SignDocument 
		--		'POST',
		--		@ProjectId,
		--		@CreatedBy,
		--		@ObjectName,
		--		@ObjectId,
		--		@SignRemark,
		--		@NextSignRole,
		--		@NextSignRoleUsersId,
		--		@AclCanDynamicName,
		--		@MachineName,
		--		@ActiveDirectoryName,
		--		@LoggedUserId,
		--		@CompanyId
		--	END
											
		COMMIT;

	End TRY
	Begin CATCH		
		RollBack;
		Throw;
	End CATCH
END

GO
/****** Object:  StoredProcedure [JobReport].[DeleteJobReport]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [JobReport].[DeleteJobReport]
@Ids [CM].[IdsTable] ReadOnly,
@UserId int
AS
BEGIN

	Begin Transaction;
	Begin Try

		Declare @ObjectIdsForDelete [CM].[IdsTable];

		Insert Into @ObjectIdsForDelete
			Select [ObjectId] From [JobReport].JobReport WHERE Id In (Select Id From @Ids)

		Update [CM].CMDocument Set 
			IsDelete = 1,
			DeletedOn = GETDATE(),
			DeletedBy = @UserId
		WHERE Id In (Select Id From @ObjectIdsForDelete) 

		Update [JobReport].JobReport Set
			[IsDelete] = 1,
			[DeletedDate] = GetDate(),
			[DeletedBy] = @UserId		
		Where Id in (Select Id from @Ids)
	
		Commit;
	End Try
	Begin Catch
		RollBack;
	End Catch

END

GO
/****** Object:  StoredProcedure [JobReport].[FetchArchiveList]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [JobReport].[FetchArchiveList]
	
	@ProjectId int,
	@CompanyId int,
	@UserId int,
	@ObjectName varchar(55),
	@AclDisciplineName varchar(55),
	@AclShowAllName varchar(55)

AS
BEGIN

	Declare @HasAclShowAll bit = 0

	Set @HasAclShowAll = SGN.FnUserHasAcl(@ProjectId,@UserId,@AclShowAllName)


	SELECT @HasAclShowAll


	DROP TABLE IF EXISTS #DocumentTemp
	DROP TABLE IF EXISTS #JobReportTemp

	CREATE TABLE #DocumentTemp(
		[Id] [int] NOT NULL
	)

	INSERT INTO #DocumentTemp EXEC SGN.GetDocumentIfUserPresentInTheSignCycle @ProjectId,@CompanyId,@UserId,@ObjectName

	SELECT * Into #JobReportTemp FROM [JobReport].JobReport 
		WHERE ProjectId = @ProjectId and CompanyId = @CompanyId and IsDelete = 0 and IsVoid = 0

	Select 
		jr.[Id],
		jr.[ReportNumber],
		jr.[ObjectId],
		jr.ProjectId,
		jr.DisciplineId,
		ou.[Name] As Discipline,
		jr.CompanyId,
		co.FullName As Company,		

		doc.DocumentOwnersRole,
		CM.AlterName(@ProjectId,@ObjectName,doc.DocumentOwnersRole,'en') AS DocumentOwnersRoleName,

		jr.ReportDate,
		jr.UserEmail As Email,

		CASE 

		WHEN doc.Accepted = 1 And doc.Complete = 1 THEN 'Accepted'
		WHEN doc.Accepted = 0 And doc.Complete = 1 THEN 'Rejected'
		ELSE 'In Progress'

		END  AS [Status],
				

		jr.CreatedBy,		
		u1.FullName As CreatedUser,
		jr.CreatedDate,

		jr.UpdatedBy,		
		u2.FullName As UpdatedUser,
		jr.UpdatedDate
	
	From #JobReportTemp jr
		join CM.CMDocument doc on doc.Id = jr.ObjectId
		join CM.OrganizationUnit ou on ou.Id = jr.DisciplineId
		join CM.Company co on co.Id = jr.CompanyId
		Left join CM.[User] u1 on u1.Id = jr.CreatedBy
		Left join CM.[User] u2 on u2.Id = jr.UpdatedBy
		Where doc.Posted =  1 AND doc.IsDelete  = 0 AND doc.IsVoid = 0 AND jr.ProjectId = @ProjectId AND jr.CompanyId = @CompanyId AND
		jr.DisciplineId IN (SELECT Id FROM SGN.TVFGetUserDisciplines(@ProjectId,@UserId,@AclDisciplineName))
		AND (@HasAclShowAll = 1 OR doc.CreatedBy = @UserId OR jr.ObjectId In (SELECT Id FROM #DocumentTemp))
		ORDER BY jr.Id DESC
END

GO
/****** Object:  StoredProcedure [JobReport].[FetchInboxList]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [JobReport].[FetchInboxList]
	@ProjectId int,
	@CompanyId int,
	@UserId int,
	@ObjectName varchar(55)
AS
BEGIN

	DROP TABLE IF EXISTS #DocumentTemp
	DROP TABLE IF EXISTS #JobReportTemp

	CREATE TABLE #DocumentTemp(
		[Id] [int] NOT NULL
	)
	
	INSERT INTO #DocumentTemp EXEC [SGN].[FetchDocumentsInNextSign]  @ProjectId,@CompanyId,@UserId,@ObjectName

	

	SELECT * Into #JobReportTemp FROM JobReport.JobReport 
		WHERE ProjectId = @ProjectId and CompanyId = @CompanyId and IsDelete = 0 and IsVoid = 0

	Select 
		jr.[Id],
		jr.[ReportNumber],
		jr.[ObjectId],
		jr.ProjectId,
		jr.DisciplineId,
		ou.[Name] As Discipline,
		jr.CompanyId,
		co.FullName As Company,
	
		doc.DocumentOwnersRole,
		CM.AlterName(@ProjectId,@ObjectName,doc.DocumentOwnersRole,'en') AS DocumentOwnersRoleName,
		
		jr.ReportDate,
		jr.UserEmail As Email,
		jr.CreatedBy,		
		u1.FullName As CreatedUser,
		jr.CreatedDate,
		jr.UpdatedBy,		
		u2.FullName As UpdatedUser,
		jr.UpdatedDate
	
	From #JobReportTemp jr
		join CM.CMDocument doc on doc.Id = jr.ObjectId
		join CM.Project pr on pr.Id = jr.ProjectId
		join CM.OrganizationUnit ou on ou.Id = jr.DisciplineId
		join CM.Company co on co.Id = jr.CompanyId
		Left join CM.[User] u1 on u1.Id = jr.CreatedBy
		Left join CM.[User] u2 on u2.Id = jr.UpdatedBy
		Where doc.Posted =  1 And jr.ObjectId In (Select Id From #DocumentTemp) order by jr.Id desc
END

GO
/****** Object:  StoredProcedure [JobReport].[FetchJobReportById]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [JobReport].[FetchJobReportById]
	@Id int
AS
BEGIN
	
	Select jr.Id, doc.Id as ObjectId,jr.CompanyId,doc.DocumentOwnersRole,jr.DisciplineId,jr.ProjectId,jr.ReportNumber,jr.ReportDate,jr.ReportContent,jr.ProblemsContent,jr.Suggestion,jr.UserEmail From [JobReport].JobReport jr
	JOIN CM.CMDocument doc on doc.Id = jr.ObjectId
	WHERE jr.Id = @Id

END

GO
/****** Object:  StoredProcedure [JobReport].[FetchJobReportList]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [JobReport].[FetchJobReportList]
	@ProjectId int,
	@CompanyId int,
	@UserId int
AS
BEGIN
	
	DROP TABLE IF EXISTS #JobReportTemp

	SELECT * Into #JobReportTemp FROM [JobReport].JobReport 
		WHERE ProjectId = @ProjectId and CompanyId = @CompanyId and CreatedBy =@UserId And IsDelete = 0 and IsVoid = 0

	Select 
		jr.[Id],
		jr.[ReportNumber],
		jr.[ObjectId],
		jr.ProjectId,
		jr.DisciplineId,
		ou.[Name] As Discipline,
		jr.CompanyId,
		co.FullName As Company,
				
		jr.ReportDate,
		jr.UserEmail As Email,


		CASE 

		WHEN doc.Accepted = 1 And doc.Complete = 1 THEN 'Accepted'
		WHEN doc.Accepted = 0 And doc.Complete = 1 THEN 'Rejected'
		ELSE 'In Progress'

		END  AS [Status],



		jr.CreatedBy,		
		u1.FullName As CreatedUser,
		jr.CreatedDate
	
	From #JobReportTemp jr
		join CM.CMDocument doc on doc.Id = jr.ObjectId
		join CM.OrganizationUnit ou on ou.Id = jr.DisciplineId
		join CM.Company co on co.Id = jr.CompanyId
		Left join CM.[User] u1 on u1.Id = jr.CreatedBy
		where doc.Posted = 0 And jr.CreatedBy = @UserId order by jr.Id desc
END

GO
/****** Object:  StoredProcedure [JobReport].[SaveAttachment]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
CREATE PROCEDURE [JobReport].[SaveAttachment]

@ProjectId as int,
@UserId as int,
@ObjectName as nvarchar(255),
@ObjectId as int,
@Files as JobReport.FileItemType READONLY

AS
BEGIN	
	Begin TRY
		Begin Transaction
	  --Merge for FileTicketAttachment table
	  MERGE [JobReport].[ftAttachmentJobReport] as t
		USING @Files As s 
		ON (t.[name] = s.[FileName] )
		WHEN NOT MATCHED By target THEN
			Insert([name],[file_stream])
			Values(s.[FileName],s.[Content]);

	 -- Merge for Attachment table
		MERGE CM.[CMAttachments] as t
		USING (
			Select 
				fat.Id As Id,
				@ProjectId As ProjectId,
				@ObjectName As ObjectName,
				@ObjectId As ObjectId,
				tft.[stream_id] As stream_id,
				tft.[creation_time] As CreatedDate,
				@UserId As CreatedUserId,
				0 As IsDelete,
				fat.[CustomType] As CustomType,
				fat.[FileType] As FileType,
				fat.[FileName] As [FileName],
				fat.[Remark] As Remark
				From JobReport.ftAttachmentJobReport tft
				join @Files fat on fat.[FileName] = tft.[name]
		) s 

		ON (t.[Id] = s.[Id] )

		WHEN NOT MATCHED By target THEN
			Insert(ProjectId,ObjectName,ObjectId,stream_id,CreatedDate,CreatedUserId,IsDelete,CustomType,FileType,[FileName],Remark)
			Values(s.ProjectId,s.ObjectName,s.ObjectId,s.stream_id,s.CreatedDate,s.CreatedUserId,0,s.CustomType,s.FileType,s.[FileName],s.Remark)

		WHEN MATCHED THEN
			UPDATE Set
			t.[ProjectId] = s.[ProjectId],
			t.[ObjectName] = s.[ObjectName],
			t.[ObjectId] = s.[ObjectId],
			t.[CustomType] = s.[CustomType],
			t.[FileType] = s.[FileType],
			t.[FileName] = s.[FileName],
			t.[Remark] = s.[Remark]	
	
		WHEN NOT MATCHED BY SOURCE And t.ObjectId = @ObjectId THEN
			Update Set
				t.[IsDelete] = 1,
				t.[DeletedDate] = GetDate(),
				t.[DeletedUserId] = @UserId,
				t.[DeletedOn] = t.[DeletedDate],
				t.[DeletedBy] = t.[DeletedUserId];			

		COMMIT
	END TRY
	BEGIN CATCH		
		ROLLBACK
	END CATCH
END

GO
/****** Object:  StoredProcedure [JobReport].[SetSeenNextSignRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [JobReport].[SetSeenNextSignRole]
@ProjectId int,
@CompanyId int,
@UserId int,
@ObjectName varchar(55),
@ObjectId int,
@NextSignRole varchar(55)
AS
BEGIN

	BEGIN TRY
		BEGIN TRAN
		DECLARE @IsSeen BIT = 0

		UPDATE CM.CMSign SET IsSeen = 1 , SeenDate = GETDATE() , SeenUser = @UserId
			WHERE ProjectId = @ProjectId AND CompanyId = @CompanyId AND ObjectName = @ObjectName AND ObjectId = @ObjectId AND NextRole = @NextSignRole AND IsSeen = 0 AND UserId <> @UserId
		COMMIT;
	END TRY
	BEGIN CATCH
	
		ROLLBACK;
		THROW;

	END CATCH






END


GO
/****** Object:  StoredProcedure [JobReport].[SignDocument]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [JobReport].[SignDocument]
	@SignRequestType varchar(55),
	@ProjectId as int,
	@UserId as int,
	@ObjectId as int,
	@Remark as nvarchar(2000),
	@NextRole as varchar(50) = NULL,
	@NextRoleUsersId  varchar(200),
	@AclCanDynamicRoleName varchar(55),
	@MachineName as nvarchar(150),
	@ActiveDirectoryName as nvarchar(250),
	@LoggedUserId as int,
	@CompanyId as int = null
AS
BEGIN

	BEGIN TRY
	BEGIN TRAN

	DECLARE @ObjectName varchar(55) 
	DECLARE @SignConfigObjectName varchar(55) 
	DECLARE @Type2 varchar(55)
	SELECT @ObjectName = [Type],@Type2 = Type2 FROM CM.CMDocument WHERE Id= @ObjectId


	DECLARE @HasAcl_Expert_To_Head bit = 0
	SET @HasAcl_Expert_To_Head = SGN.FnUserHasAcl(@ProjectId,@UserId,CONCAT(@ObjectName,'.','Expert_To_Head'))

	DECLARE @HasAcl_Head_To_Manager bit = 0
	SET @HasAcl_Head_To_Manager = SGN.FnUserHasAcl(@ProjectId,@UserId,CONCAT(@ObjectName,'.','Head_To_Manager'))


	IF @HasAcl_Expert_To_Head = 1 AND @HasAcl_Head_To_Manager = 1
		THROW 50001,'Can not have role ''Expert_To_Head'' and ''Head_To_Manager'' at same time!',1  

	Set @SignConfigObjectName = CONCAT(@ObjectName,'.',@Type2)


	EXEC SGN.SignDocument
		@SignRequestType = @SignRequestType,
		@ProjectId = @ProjectId,
		@UserId = @UserId,
		@ObjectName = @ObjectName,
		@SignConfigObjectName = @SignConfigObjectName,
		@ObjectId = @ObjectId,
		@Remark = @Remark,
		@NextRole = @NextRole,
		@NextRoleUsersId = @NextRoleUsersId,
		@AclCanDynamicRoleName = @AclCanDynamicRoleName,
		@MachineName = @MachineName,
		@ActiveDirectoryName = @ActiveDirectoryName,
		@LoggedUserId = @LoggedUserId,
		@CompanyId = @CompanyId

		COMMIT;
	END TRY

	BEGIN CATCH
	ROLLBACK
	;THROW

	END CATCH








END

GO
/****** Object:  StoredProcedure [JobReport].[UpdateJobReport]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [JobReport].[UpdateJobReport]
@Id int,
@ObjectId int,
@ProjectId int,
@DisciplineId int,
@CompanyId int,
@UpdatedBy int,
@ReportDate DateTime,
@UserEmail VARCHAR(MAX),
@ReportContent NVARCHAR(MAX),
@ProblemsContent NVARCHAR(MAX),
@Suggestion NVARCHAR(MAX),
@Files as JobReport.FileItemType ReadOnly

AS
BEGIN	
	Begin TRY
			
		BEGIN TRAN UpdateTRAN

		DECLARE @ObjectName varchar(55)
		SELECT @ObjectName = [Type] FROM CM.CMDocument WHERE Id = @ObjectId

		exec JobReport.SaveAttachment @ProjectId,@UpdatedBy,@ObjectName,@ObjectId,@Files
			
		UPDATE JobReport.JobReport SET
			ProjectId = @ProjectId,
			DisciplineId = @DisciplineId,
			CompanyId = @CompanyId,
			UpdatedBy = @UpdatedBy,
			UpdatedDate = GETDATE(),
			ReportDate = @ReportDate,
			UserEmail = @UserEmail,
			ReportContent = @ReportContent,
			ProblemsContent = @ProblemsContent,
			Suggestion = @Suggestion
		WHERE Id = @Id
		
		Update CM.CMDocument SET
			ProjectId = @ProjectId,
			CompanyId = @CompanyId,
			DisciplineId = @DisciplineId,
			ModifiedOn = GetDate(),
			ModifiedBy = @UpdatedBy
		WHERE Id = @ObjectId		

		COMMIT TRAN UpdateTRAN
	End TRY
	Begin CATCH	
		RollBack TRAN UpdateTRAN;
		THROW;		
	End CATCH
END

GO
/****** Object:  StoredProcedure [Notify].[ActiveUserSetSessionNotify]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Notify].[ActiveUserSetSessionNotify]
@UserId int,
@StreamId uniqueidentifier
AS
BEGIN
	BEGIN TRY
	BEGIN TRANSACTION

		INSERT INTO Notify.NotificationDetail(UserId) VALUES (@UserId)
		COMMIT;

	END TRY
	BEGIN CATCH
		ROLLBACK;
	END CATCH




END

GO
/****** Object:  StoredProcedure [Notify].[CheckUserInActiveSession]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Notify].[CheckUserInActiveSession]
@UserId int
AS
BEGIN	
	SELECT Count(Id) FROM Notify.NotifyActiveUser WHERE UserId = @UserId AND [Status] = 1
END

GO
/****** Object:  StoredProcedure [Notify].[GetNotificationData]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Notify].[GetNotificationData]
@UserId int
AS
BEGIN
	SELECT [NotifyData] FROM Notify.NotifyActiveUser WHERE UserId = @UserId
END

GO
/****** Object:  StoredProcedure [Notify].[GetNotificationDatailFrame]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [Notify].[GetNotificationDatailFrame]
@DetailId int
AS
BEGIN

	SELECT fan.[stream_id],fan.[file_stream] FROM Notify.ftAttachmentNotify  fan
	JOIN NotificationDetatilAttachment nda ON nda.StreamId = fan.stream_id
	WHERE nda.NotifyDetailId = @DetailId

END
GO
/****** Object:  StoredProcedure [Notify].[GetNotificationDetail]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [Notify].[GetNotificationDetail]


As
BEGIN

	select nd.Id,nd.UserId,u.FullName,nd.StartDate,nd.EndDate from Notify.NotificationDetail nd
	JOIN CM.[User] u on u.Id = nd.UserId

END

GO
/****** Object:  StoredProcedure [Notify].[GetNotifyActiveUsers]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [Notify].[GetNotifyActiveUsers]

AS
BEGIN
	
	SELECT * FROM Notify.NotifyActiveUser


END

GO
/****** Object:  StoredProcedure [Notify].[GetNotifyUsers]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [Notify].[GetNotifyUsers]

AS
BEGIN
	
	SELECT * FROM Notify.NotifyUsers


END

GO
/****** Object:  StoredProcedure [Notify].[SetNotificationData]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Notify].[SetNotificationData]
@UserId int,
@NotifyData varbinary(MAX)
AS
BEGIN
	BEGIN TRY
		BEGIn TRANSACTION
			UPDATE Notify.NotifyActiveUser SET NotifyData = @NotifyData WHERE UserId = @UserId
		COMMIT;
	END TRY
	BEGIN CATCH
		ROLLBACK;
	END CATCH
END

GO
/****** Object:  StoredProcedure [Notify].[SetNotificationDetail]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Notify].[SetNotificationDetail]
@UserId int,
@InsertedId int output
As
BEGIN
	BEGIN TRY
	BEGIN TRANSACTION

		DECLARE @InsertedIds Table (id int);
		Insert INTO notify.NotificationDetail(UserId,StartDate,EndDate)
			Output inserted.Id into @InsertedIds
		 VALUES
		(@UserId,GETDATE(),GETDATE());

		Select TOP 1 @InsertedId = id FROM @InsertedIds

		COMMIT
	END TRY	
	BEGIN CATCH
		ROLLBACK;
	END CATCH
		
END

GO
/****** Object:  StoredProcedure [Notify].[SetNotificationDetailAttachment]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Notify].[SetNotificationDetailAttachment]
@NotifyDetailId int,
@FileName nvarchar(255),
@File varbinary(MAX)
As
BEGIN
	BEGIN TRY
	BEGIN TRANSACTION

		Declare @stream_ids Table(stream_id uniqueidentifier);
		Insert Into Notify.ftAttachmentNotify(file_stream,[name])
			output inserted.stream_id into @stream_ids
			VALUES(@File,@FileName)

		DECLARE @stream_id uniqueidentifier;
		SELECT TOP 1 @stream_id = [stream_id] FROM @stream_ids


		INSERT INTO Notify.NotificationDetatilAttachment (NotifyDetailId,StreamId)
			Values (@NotifyDetailId,@stream_id)

		COMMIT
	END TRY	
	BEGIN CATCH
		ROLLBACK;
	END CATCH
		
END

GO
/****** Object:  StoredProcedure [Notify].[SetNotifyActiveUser]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [Notify].[SetNotifyActiveUser]
@UserId int,
@MachineName nvarchar(200),
@ActiveDirectoryName nvarchar(200),
@IpAddress varchar(15)
AS
BEGIN

	BEGIN TRY
		BEGIN TRAN
			Declare @ExistUser bit = 0;
			Select @ExistUser = Count(Id) From Notify.NotifyActiveUser
				WHERE UserId = @UserId

			IF @ExistUser = 0
				
				BEGIN
		
				INSERT INTO Notify.NotifyActiveUser (
				UserId,
				MachineName,
				ActiveDirectoryName,
				IpAddress		
				) values		
				(
					@UserId,
					@MachineName,
					@ActiveDirectoryName,
					@IpAddress					
				)
		
				END
			ELSE
				THROW 50000,'The user already selected!',1;

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK;
		THROW;
	END CATCH

END

GO
/****** Object:  StoredProcedure [Notify].[SetOnlineUsers]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [Notify].[SetOnlineUsers]
@UserId int,
@MachineName nvarchar(200),
@ActiveDirectoryName nvarchar(200),
@IpAddress varchar(15)
AS
BEGIN

	BEGIN TRY
		BEGIN TRAN
			Declare @ExistUser bit = 0;
			Select @ExistUser = Count(Id) From Notify.NotifyUsers
				WHERE UserId = @UserId


			IF @ExistUser = 0

				BEGIN
		
				INSERT INTO Notify.NotifyUsers (
				UserId,
				LastCheckDate,
				MachineName,
				ActiveDirectoryName,
				IpAddress		
				) values		
				(
					@UserId,
					GetDate(),
					@MachineName,
					@ActiveDirectoryName,
					@IpAddress					
				)
		
				END

			ELSE

				BEGIN

				UPDATE Notify.NotifyUsers
				SET LastCheckDate = GetDate()
				WHERE UserId = @UserId

				END
		
		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK;
		THROW;
	END CATCH

END

GO
/****** Object:  StoredProcedure [Notify].[SetStopNoticationDetail ]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Notify].[SetStopNoticationDetail ]
@NotifyDetailId int
AS
BEGIN

	BEGIN TRY	
	BEGIN TRAN
	UPDATE Notify.NotificationDetail SET EndDate = GETDATE() WHERE Id = @NotifyDetailId
	COMMIT;
	END TRY

	BEGIN CATCH 
	ROLLBACK;

	END CATCH


END

GO
/****** Object:  StoredProcedure [Notify].[StartNotify]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Notify].[StartNotify]
@UserId int,
@Status bit
AS
BEGIN
	BEGIN TRY
	BEGIN TRANSACTION

	Update Notify.NotifyActiveUser SET [Status] = @Status WHERE UserId = @UserId

	COMMIT;



	END TRY

	BEGIN CATCH
	ROLLBACK;
	END CATCH




END

GO
/****** Object:  StoredProcedure [Notify].[UnSetNotifyActiveUser]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [Notify].[UnSetNotifyActiveUser]
@UserId int
AS
BEGIN

	BEGIN TRY
		BEGIN TRAN
			DELETE FROM Notify.NotifyActiveUser WHERE UserId = @UserId

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK;
		THROW;
	END CATCH

END

GO
/****** Object:  StoredProcedure [QCEL].[DeleteCFDocument]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [QCEL].[DeleteCFDocument]
@DocumentId INT,
@UserId INT
AS
BEGIN

	BEGIN TRY
	BEGIN TRAN

	-- If need to check acl can write here

	UPDATE CM.CMDocument SET
	IsDelete = 1,
	DeletedBy = @UserId,
	DeletedOn = GETDATE()
	WHERE Id = @DocumentId

	COMMIT;
	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK;
		THROW;

	END CATCH
END




GO
/****** Object:  StoredProcedure [QCEL].[FETCH_CF_List]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [QCEL].[FETCH_CF_List]
@ProjectId INT
AS
BEGIN
	SELECT doc.Id AS documentId, doc.ProjectId,cf.Id,cf.RevisionId,doc.UnitId, doc.ReportNo, doc.CreatedBy, doc.Posted, doc.CreateDate, doc.Complete, doc.Accepted, doc.CompanyId, doc.Type, doc.DisciplineId, doc.ContractorId, doc.ContractId, doc.Type2 AS CFType, doc.DocumentOwnersRole, doc.Approved, doc.IsDelete, doc.IsVoid, doc.PostedOn, doc.UId, doc.RevNo,dwg.[DWG No.] AS DwgNo, cf.Location,cf.CFTypeId
	, emp.Name, co.Name,u.FullName AS CreatedUser,unit.Name FROM CM.CMDocument doc
	JOIN QCEL.CF cf ON cf.DocumentId = doc.Id
	JOIN CM.Company emp ON emp.Id = doc.CompanyId
	JOIN CM.Company co ON co.Id = doc.ContractorId
	JOIN CM.[User] u ON u.Id = doc.CreatedBy
	JOIN CM.Unit unit ON unit.Id = doc.UnitId
	JOIN CMIS_Developer.DCC.vQCEL_PlanRevisionNo dwg ON dwg.RevisionId = cf.RevisionId
	WHERE doc.ProjectId = @ProjectId
END

GO
/****** Object:  StoredProcedure [QCEL].[FetchAttachments]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [QCEL].[FetchAttachments]
@ObjectId INT
AS
BEGIN	

	BEGIN TRY
		SELECT cmatt.Id, cmatt.stream_id, cmatt.CreatedDate, cmatt.CreatedUserId, cmatt.IsDelete, cmatt.IsUsed, cmatt.CustomType, cmatt.FileType, cmatt.FileName,NULL As FilePath, cmatt.Remark,'QCEL.ftAttachment' AS FileTableName , cmatt.Type,'File' AS [File] FROM CM.CMAttachments cmatt
		JOIN QCEL.ftAttachment ft ON ft.stream_id = cmatt.stream_id
		WHERE cmatt.ObjectId = @ObjectId AND cmatt.IsDelete = 0

	END TRY

	BEGIN CATCH
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [QCEL].[FetchCF_819]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [QCEL].[FetchCF_819]
@DocumentId INT,
@CfTypeId INT
AS
BEGIN
	SELECT doc.Id AS documentId, doc.ProjectId,cf.Id AS CfId,cf.RevisionId,doc.UnitId, doc.ReportNo, doc.CreatedBy, doc.Posted, doc.CreateDate, doc.Complete, doc.Accepted, doc.CompanyId, doc.Type AS ObjectName, doc.DisciplineId, doc.ContractorId, doc.ContractId, doc.Type2, doc.DocumentOwnersRole, doc.Approved, doc.IsDelete, doc.IsVoid, doc.PostedOn, cf.Location, cf.VoltageCableType,cf.CFTypeId
	FROM CM.CMDocument doc
	JOIN QCEL.CF cf ON cf.DocumentId = doc.Id
	JOIN CM.Company emp ON emp.Id = doc.CompanyId
	JOIN CM.Company co ON co.Id = doc.ContractorId
	JOIN CM.[User] u ON u.Id = doc.CreatedBy
	JOIN CM.Unit unit ON unit.Id = doc.UnitId
	JOIN CMIS_Developer.DCC.vQCEL_PlanRevisionNo dwg ON dwg.RevisionId = cf.RevisionId
	WHERE doc.Id = @DocumentId AND doc.Type = 'QCEL' AND cf.CFTypeId = @CfTypeId  ORDER BY doc.Id
END

GO
/****** Object:  StoredProcedure [QCEL].[FetchCF_WithFixedItems]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [QCEL].[FetchCF_WithFixedItems] 
@ProjectId INT,
@UserId INT
AS
BEGIN
	
	BEGIN TRY
		DECLARE @HasAccess BIT = 0;
		SET @HasAccess = SGN.FnUserHasAcl(@ProjectId,@UserId,'QCEL.ShowCFList')

		IF @HasAccess = 0 THROW 50002,'You don''t have access!',1

	
		DECLARE @ContractTemp TABLE(Id INT NULL,EmployerId INT NULL,ContractorId INT NULL,ContractorSymbol NVARCHAR(20)NULL,EmployerSymbol NVARCHAR(20) NULL,Contractor NVARCHAR(250) NULL,Employer NVARCHAR(250) NULL,[Contract] NVARCHAR(300) NULL);
    
		INSERT INTO @ContractTemp(Id,EmployerId,ContractorId,ContractorSymbol,EmployerSymbol,Contractor,Employer,Contract)
		EXEC CM.FetchContractsCombo @ProjectId = @ProjectId,@UserId = @UserId,@Acl = 'QCEL.Contract';


		SELECT * FROM CM.CMDocument doc
		INNER JOIN QCEL.CF cf ON cf.DocumentId = doc.Id

	END TRY
	BEGIN CATCH
		THROW;
	END CATCH








END

GO
/****** Object:  StoredProcedure [QCEL].[FetchCFItems]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [QCEL].[FetchCFItems]
@CFId INT = NULL,
@CFTypeId INT
AS
BEGIN
	SELECT cfir.Id,cfi.Id AS ItemId,cfi.[Order] AS RowNo, cfi.Name,
	CAST(IIF(cfir.ItemValue = 1,1,0) AS BIT) ACC,
	CAST(IIF(cfir.ItemValue = -1,1,0) AS BIT) REJ,
	CAST(IIF(cfir.ItemValue = 0 AND @CFId IS NOT NULL ,1,0) AS BIT) NA,
	CAST(cfir.ItemValue AS INT) AS ItemValue
	FROM QCEL.CFItems cfi
	LEFT JOIN QCEL.CFItemsResult cfir ON cfir.ItemId = cfi.Id AND cfir.CFId = @CFId
	WHERE cfi.CFTypeId = @CFTypeId
	ORDER BY cfi.[Order]
END

GO
/****** Object:  StoredProcedure [QCEL].[SaveCF_WithFixedItems]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [QCEL].[SaveCF_WithFixedItems]
@Id INT = NULL OUTPUT,
@CFTypeId INT,
@ProjectId INT,
@EmployerId INT,
@ContractId INT,
@ContractorId INT,
@UserId INT,
@ObjectName VARCHAR(50),
@Type2 VARCHAR(50) = NULL,
@RevisionId INT,
@UnitId INT = NULL,
@Remark NVARCHAR(500) = NULL,
@RevNo VARCHAR(10) = NULL,
@Location NVARCHAR(100) = NULL,
@VoltageCableType INT = NULL,
@ReportNoParameters VARCHAR(100) = NULL,
@Attachments CM.TVPAttachment READONLY,
@ItemsResult QCEL.TVPCFItemsResult READONLY
AS
BEGIN

	BEGIN TRY
	BEGIN TRAN

	-- DECLARE Identities
	DECLARE @DocumentId INT;
	DECLARE @DisciplineId INT = NULL;
	DECLARE	@ReportNo varchar(255),@CounterId INT;
	DECLARE @CFId INT = NULL;

	-- Get Discipline From Config Table
	SELECT @DisciplineId = [Value] FROM CM.Config WHERE ProjectId = @ProjectId AND Scope = @objectName AND [Name] = 'DisciplineId'
	IF @DisciplineId IS NULL THROW 50001,'DisciplineId not declared!',1;

	-- Save Document AND CF Form
	IF @Id IS NULL OR @Id = 0
	BEGIN

		-- Generate Report Number
		EXEC [CM].[GenerateReportNumber]
			@ProjectId = @ProjectId,
			@CompanyId = @ContractorId,
			@DisciplineId = @DisciplineId,
			@ObjectName = @ObjectName,
			@Parameters = @ReportNoParameters,
			@CounterId = @CounterId OUTPUT,
			@ReportNumber = @ReportNo OUTPUT

		-- Create Document
		EXEC CM.CreateDocument
			@ProjectId=@ProjectId, -- int
			@ReportNo=@ReportNo, -- varchar(255)
			@CreatedBy=@UserId, -- int
			@CompanyId=@EmployerId, -- int
			@Type=@ObjectName, -- varchar(50)
			@DisciplineId=@DisciplineId, -- int
			@Type2=@Type2, -- varchar(50)
			@Remark=@Remark, -- nvarchar(300)
			@UnitId=@UnitId, -- int
			@ContractId=@ContractId, -- int
			@ContractorId=@ContractorId, -- int
			@RevNo=@RevNo, -- varchar(10)
			@Identity=@DocumentId OUTPUT

		-- Create CF Forms
		INSERT INTO QCEL.CF(CFTypeId,DocumentId, RevisionId, Location, VoltageCableType)
		VALUES(@CFTypeId,@DocumentId,@RevisionId,@Location,@VoltageCableType);
		SET @CFId = SCOPE_IDENTITY();
		IF @CFId IS NULL THROW 50002,'Operation Faild, Becuase CFId is null!',1;

		SET @Id = @CFId;

		--Increment ReportNumber Counter
		EXEC CM.IncrementReportNumber @CounterId= @CounterId -- int

	END
	ELSE
	BEGIN

	SELECT @DocumentId = doc.Id FROM QCEl.CF cf
	JOIN CM.CMDocument doc ON doc.Id = cf.DocumentId	
	WHERE cf.Id = @Id
	
	--Set CFId value
	SET @CFId = @Id
		
	-- Update Document
	UPDATE CM.CMDocument SET
    ModifiedOn = GETDATE(),
	ModifiedBy = @UserId,
	Remark = @Remark,
	RevNo = @RevNo
	WHERE Id= @DocumentId

	-- Update CF Form
	UPDATE QCEL.CF SET
    RevisionId = @RevisionId,
	Location = @Location,
	VoltageCableType = @VoltageCableType
	WHERE Id = @Id

	END
	
	 -- Merge CF Items Value
		MERGE QCEL.CFItemsResult as t
		USING (
			SELECT Id,RoleOrder,ItemId,ItemValue
			FROM @ItemsResult			
		) s 

		ON (t.[Id] = s.[Id] )

		WHEN NOT MATCHED By target THEN
			Insert(CFId,RoleOrder,ItemId,ItemValue,CreatedBy,CreatedDate)
			Values(@CFId,s.RoleOrder,s.ItemId,s.ItemValue,@UserId,GETDATE())
		WHEN MATCHED THEN
			UPDATE Set
			t.ItemValue = s.ItemValue,
			t.UpdatedBy	= @UserId,
			t.UpdatedDate = GETDATE()
		WHEN NOT MATCHED BY SOURCE AND t.CFId = @CFId THEN
			DELETE;


	-- Create Attachmnets
		-- Merge fileTable
		MERGE QCEL.ftAttachment as t
		USING (
			SELECT stream_id,FileStream,FileName
			FROM @Attachments			
		) s 

		ON (t.[stream_id] = s.[stream_id] )

		WHEN NOT MATCHED By target THEN
			Insert(stream_id,file_stream,name)
			Values(s.stream_id,s.FileStream,s.FileName)
		--WHEN MATCHED THEN
		--	UPDATE Set
		--	t.file_stream = s.FileStream,
		--	t.name = s.FileName;

		-- Merge CMAttachment Table
		;MERGE CM.CMAttachments as t
		USING (
			SELECT att.Id,att.stream_id,att.FileName,att.Remark,att.Type,att.CustomType,ft.creation_time,ft.file_type,@ProjectId AS ProjectId,@ObjectName AS ObjectName,@DocumentId AS ObjectId,@UserId AS UId FROM @Attachments att			
			INNER JOIN QCEL.ftAttachment ft ON ft.stream_id = att.stream_id
		) s

		ON (t.Id = s.Id)

		WHEN NOT MATCHED By target THEN
			Insert(ProjectId,ObjectName,ObjectId,stream_id,CreatedDate,CreatedUserId,IsUsed,Type,CustomType,FileType,FileName,Remark)
			Values(s.ProjectId,s.ObjectName,s.ObjectId,s.stream_id,s.creation_time,s.UId,1,s.Type,s.CustomType,s.file_type,s.FileName,s.Remark)	
		WHEN NOT MATCHED BY SOURCE AND t.ObjectId = @DocumentId THEN
			UPDATE SET
			t.IsDelete = 1,
			t.DeletedBy = @UserId,
			t.DeletedDate = GETDATE();


		

	COMMIT;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0 ROLLBACK;
		THROW;
	END CATCH
END

GO
/****** Object:  StoredProcedure [QCEL].[SignDocument]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [QCEL].[SignDocument]

@SignRequestType varchar(55),
@ProjectId as int,
@UserId as int,
@ObjectId as int,
@Remark as nvarchar(2000) = NULL,
@NextRole as varchar(50) = NULL,
@NextRoleUsersId  varchar(200) = NULL,
@AclCanDynamicRoleName varchar(55) = NULL,
@MachineName as nvarchar(150) = NULL,
@ActiveDirectoryName as nvarchar(250) = NULL,
@LoggedUserId as int = NULL,
@CompanyId as int = NULL

AS
BEGIN
	
	BEGIN TRY
	BEGIN TRAN

	DECLARE @ObjectName varchar(55) 
	DECLARE @SignConfigObjectName varchar(55)

	SELECT @ObjectName = [Type],@SignConfigObjectName = CONCAT([Type],'.',Type2) FROM CM.CMDocument WHERE Id= @ObjectId
	
	EXEC SGN.SignDocument
		@SignRequestType = @SignRequestType,
		@ProjectId = @ProjectId,
		@UserId = @UserId,
		@ObjectName = @ObjectName,
		@SignConfigObjectName = @SignConfigObjectName,
		@ObjectId = @ObjectId,
		@Remark = @Remark,
		@NextRole = @NextRole,
		@NextRoleUsersId = @NextRoleUsersId,
		@AclCanDynamicRoleName = @AclCanDynamicRoleName,
		@MachineName = @MachineName,
		@ActiveDirectoryName = @ActiveDirectoryName,
		@LoggedUserId = @LoggedUserId,
		@CompanyId = @CompanyId

		COMMIT;
	END TRY
	BEGIN CATCH
	 IF @@TRANCOUNT>0 ROLLBACK;
	 THROW
	END CATCH 
END

GO
/****** Object:  StoredProcedure [SecAcl].[FetchACL]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [SecAcl].[FetchACL]
@Id int,
@ProjectId int,
@IsGroup bit = 0
AS
BEGIN
	IF @IsGroup = 0
		BEGIN
			Select acl.Id,acl.[Name],acl.Allow,acli.Id as AclItemId,acli.[Value] FROM CM.CMAcl acl
				Left Join CM.CMAclItem acli ON acli.AclId = acl.Id
				WHERE acl.ProjectId = @ProjectId AND acl.UserId = @Id
		END
	ELSE
		BEGIN
			Select acl.Id,acl.[Name],acl.Allow,acli.Id as AclItemId,acli.[Value] FROM CM.CMAcl acl
				Left Join CM.CMAclItem acli ON acli.AclId = acl.Id
				WHERE acl.ProjectId = @ProjectId AND acl.GroupId = @Id
		END
END










GO
/****** Object:  StoredProcedure [SecAcl].[FetchAclList]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [SecAcl].[FetchAclList]
@ProjectId int
AS
BEGIN

	SELECT * FROM CM.CMAcl acl
	WHERE acl.ProjectId = @ProjectId
	Order By Id

END










GO
/****** Object:  StoredProcedure [SecAcl].[FetchCompaniesData]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [SecAcl].[FetchCompaniesData] 

AS
BEGIN

	SELECT  [Id], [FullName] FROM CM.Company

END

GO
/****** Object:  StoredProcedure [SecAcl].[FetchContractsData]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [SecAcl].[FetchContractsData]

AS
BEGIN
	SELECT cont.Id,CONCAT(contractor.FullName,' => [',emp.Symbol,']') AS [Name] FROM CM.[Contract] cont
	JOIN CM.Company emp ON emp.Id = cont.EmployerId
	JOIN CM.Company contractor ON contractor.Id = cont.ContractorId
END
GO
/****** Object:  StoredProcedure [SecAcl].[FetchDisciplineForAcls]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [SecAcl].[FetchDisciplineForAcls]
@ProjectId as int,
@IsDiscipline bit = NULL
AS
BEGIN

SELECT [Id],[Name]
  FROM [CMIS].[CM].[OrganizationUnit]

  Where (@IsDiscipline IS NULL OR IsDiscipline = @IsDiscipline) AND ProjectId = @ProjectId

END

GO
/****** Object:  StoredProcedure [SecAcl].[GetProjectList]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [SecAcl].[GetProjectList] 

AS
BEGIN

	SELECT [Id],CONCAT([Name],'-',[Code]) As [Name] FROM CM.Project
	WHERE Active = 1

END

GO
/****** Object:  StoredProcedure [SecAcl].[GetUserGroupList]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [SecAcl].[GetUserGroupList]
@ProjectId int
AS
BEGIN

	SELECT 
		ug.Id,
		ug.ProjectId,
		ug.[Name],
		ug.[Description],
		'Permision' AS Permision					
	 FROM CM.[UserGroup] ug
		WHERE ug.ProjectId = @ProjectId

END

GO
/****** Object:  StoredProcedure [SecAcl].[GetUserList]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [SecAcl].[GetUserList]

AS
BEGIN
	SELECT 
		usr.[Id],
		co.[FullName] Company,
		usr.UserName,
		usr.FirstName,
		usr.LastName,
		usr.FullName,
		usr.JobTitle,
		usr.ProfileImage,
		'Permision' AS 'Permision'
	 FROM CM.[User] usr
	 JOIN CM.Company co on co.Id = usr.CompanyId
	 Order By usr.Id
END

GO
/****** Object:  StoredProcedure [SecAcl].[SaveChangeACL]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [SecAcl].[SaveChangeACL]
@ProjectId int,
@Id int = null,
@IsGroup bit = 0,
@ACLS AS [SecAcl].ACLTableType ReadOnly
AS
BEGIN
	
	Begin TRY
	 -- Merge for Attachment table
	IF @IsGroup = 0	
		BEGIN
			MERGE CM.[CMAcl] as t
			USING (
				Select 
					acls.Id,
					acls.[Name],
					acls.Allow as Allow
					From @ACLS acls
			) s 

			ON (t.[Id] = s.[Id] )

			WHEN NOT MATCHED By target THEN
				Insert([Name],[Allow],UserId,ProjectId)
				Values(s.[Name],s.Allow,@Id,@ProjectId)		

			WHEN MATCHED THEN
				UPDATE Set
				t.[ProjectId] = @ProjectId,
				t.[UserId] = @Id,
				t.[Name] = s.[Name],
				t.[Allow] = s.[Allow]
			
		
			WHEN NOT MATCHED BY SOURCE AND t.UserId = @Id And t.ProjectId = @ProjectId THEN
				Delete;		


			-- Merge ACL Item 
			;WITH aclCTE as(
				SELECT acl1.[Name],acl2.[value] FROM @Acls acl1
				CROSS APPLY string_split(acl1.[Value],',') as acl2
				WHERE acl2.[value] <> ''
			)

			MERGE CM.CMAclItem tar
			USING (
				Select acl.[Id] as AclId,aclcte.[value] as [Value] FROM aclCTE aclcte
				Join CM.CMAcl acl ON acl.[Name] = aclcte.[Name]
				Where acl.UserId = @Id And acl.ProjectId = @ProjectId
			) src
			ON (tar.[AclId] = src.[AclId] AND tar.[Value] = src.[Value] )

			WHEN NOT MATCHED By target THEN
				Insert([AclId],[Value])
				Values(src.AclId,src.[Value])		
		
			WHEN NOT MATCHED BY SOURCE AND tar.AclId IN (
				SELECT acli.AclId FROM CM.CMAclItem acli
				JOIN CM.CMAcl acl ON acl.Id = acli.AclId
				WHERE acl.UserId = @Id	AND acl.ProjectId = @ProjectId	
			)  THEN
				Delete;

		END
	ELSE
		BEGIN
			MERGE CM.[CMAcl] as t
			USING (
				Select 
					acls.Id,
					acls.[Name],
					acls.Allow as Allow
					From @ACLS acls
			) s 

			ON (t.[Id] = s.[Id] )

			WHEN NOT MATCHED By target THEN
				Insert([Name],[Allow],GroupId,ProjectId)
				Values(s.[Name],s.Allow,@Id,@ProjectId)		

			WHEN MATCHED THEN
				UPDATE Set
				t.[ProjectId] = @ProjectId,
				t.[GroupId] = @Id,
				t.[Name] = s.[Name],
				t.[Allow] = s.[Allow]
			
		
			WHEN NOT MATCHED BY SOURCE AND t.GroupId = @Id And t.ProjectId = @ProjectId THEN
				Delete;		


			-- Merge ACL Item 
			;WITH aclCTE as(
				SELECT acl1.[Name],acl2.[value] FROM @Acls acl1
				CROSS APPLY string_split(acl1.[Value],',') as acl2
				WHERE acl2.[value] <> ''
			)

			MERGE CM.CMAclItem tar
			USING (
				Select acl.[Id] as AclId,aclcte.[value] as [Value] FROM aclCTE aclcte
				Join CM.CMAcl acl ON acl.[Name] = aclcte.[Name]
				Where acl.GroupId = @Id And acl.ProjectId = @ProjectId
			) src
			ON (tar.[AclId] = src.[AclId] AND  tar.[Value] = src.[Value] )
			WHEN NOT MATCHED By target THEN
				Insert([AclId],[Value])
				Values(src.AclId,src.[Value])		
		
			WHEN NOT MATCHED BY SOURCE AND tar.AclId IN (
				SELECT acli.AclId FROM CM.CMAclItem acli
				JOIN CM.CMAcl acl ON acl.Id = acli.AclId
				WHERE acl.GroupId = @Id	AND acl.ProjectId = @ProjectId	
			)  THEN
				Delete;	


		END
	END TRY
	BEGIN CATCH		
		THROW;
	END CATCH
END
GO
/****** Object:  StoredProcedure [SGN].[FetchDocumentsInNextSign]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [SGN].[FetchDocumentsInNextSign]

@ProjectId int,
@CompanyId int,
@UsersId int,
@ObjectName varchar(55),
@GroupId as INT  = NULL

AS
BEGIN

	DROP TABLE IF EXISTS #SignTemp

	SELECT ROW_NUMBER() OVER(PARTITION BY [ProjectId], [ObjectName] , [ObjectId], [NextRole] ORDER BY Id DESC) AS RowNumber,Id,[ProjectId],[ObjectName],[ObjectId],[NextRole],[NextRoleUsersId],CompanyId INTO #SignTemp FROM CM.[CMSign] sgn
				WHERE ProjectId = @ProjectId AND ObjectName = @ObjectName And (CompanyId IS NULL OR CompanyId = @CompanyId) 

	Select doc.Id FROM Cm.CMDocument doc
	JOIN #SignTemp sgn ON sgn.ObjectId = doc.Id AND sgn.NextRole = doc.DocumentOwnersRole
	WHERE sgn.ObjectName = @ObjectName AND 
	SGN.FnUserHasAcl(@ProjectId,@UsersId,CONCAT(@ObjectName,'.',doc.DocumentOwnersRole)) = 1
	AND (sgn.NextRoleUsersId IS NULL OR sgn.NextRoleUsersId = N'' OR @UsersId IN (SELECT VALUE FROM string_split(sgn.[NextRoleUsersId],';')))
	AND sgn.RowNumber = 1

END
GO
/****** Object:  StoredProcedure [SGN].[FetchNextRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [SGN].[FetchNextRole]
@ObjectId int,
@NextRole varchar(55) output
AS
BEGIN

	DECLARE  @ProjectId int,@CompanyId int = NULL,@Role varchar(55),@ObjectName varchar(55)
	SELECT @ProjectId = ProjectId,@CompanyId = CompanyId,@Role = DocumentOwnersRole,@ObjectName = [Type]  FROM CM.CMDocument WHERE Id = @objectId

	IF @Role IS NULL
		SET @Role = SGN.FnFirstSignRole(@ProjectId,@CompanyId,@ObjectName)

	SELECT @NextRole = [NextRole] FROM SGN.TVFGetPostSignSteps(@ProjectId,@CompanyId,@ObjectName)
	WHERE [Role] = @Role

	
END

GO
/****** Object:  StoredProcedure [SGN].[FetchPreviuosRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [SGN].[FetchPreviuosRole]
@ObjectId int,
@NextRole varchar(55) output
AS
BEGIN
	DECLARE  @ProjectId int,@CompanyId int = NULL,@Role varchar(55),@ObjectName varchar(55)
	SELECT @ProjectId = ProjectId,@CompanyId = CompanyId,@Role = DocumentOwnersRole,@ObjectName = [Type]  FROM CM.CMDocument WHERE Id = @objectId
	SELECT @NextRole = [NextRole] FROM SGN.TVFGetBackSignSteps(@ProjectId,@CompanyId,@ObjectName)
	WHERE [Role] = @Role
END

GO
/****** Object:  StoredProcedure [SGN].[FetchSignatureHistoryList]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [SGN].[FetchSignatureHistoryList]
@ProjectId as int,
@ObjectName as varchar(55),
@ObjectId as int

As
Begin

	DROP TABLE IF EXISTS #SignTemp

	Select * INTO #SignTemp From CM.[CMSign]
		Where ProjectId = @ProjectId and ObjectName = @ObjectName and ObjectId = @ObjectId

	Select st.[Order],usr1.[FullName] As [User], 
	CM.AlterName(@ProjectId,@ObjectName,st.[Role],'en') As [Role],
	st.CreateDate As [SignDate],st.Accepted,st.Remark,CM.AlterName(@ProjectId,@ObjectName,st.[NextRole],'en') As NextRole,st.MachineName,st.ActiveDirectoryName As ActiveDirectory,st.IsSeen,usr3.FullName As SeenUser,st.SeenDate,usr.FullName As CreatedBy From #SignTemp  st
		Left join CM.[User] usr on  usr.Id = st.UserId
		Left join CM.[User] usr1 on  usr1.Id = st.RoleUserId 
		Left Join CM.[User] usr3 on usr3.Id = st.SeenUser
		Left join CM.[Messages] msgs on msgs.[Name] = st.[NextRole]
End






GO
/****** Object:  StoredProcedure [SGN].[FetchSignRoleUsers]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [SGN].[FetchSignRoleUsers]

@ProjectId as int,
@ObjectId as int,
@DisciplineId as int,
@NextRole as varchar(55)

AS
BEGIN

	Declare @UsersInRole Table(Id int,FullName nvarchar(155),[Role] varchar(55),JobTitle NVarchar(120),[ProfileImage] varbinary(Max))

	Declare @AllAccessDisciplines Table(Id int,Symbol varchar(55),Name varchar(55),UserId int)


	SELECT @NextRole = CONCAT([Type],'.',@NextRole) FROM CM.CMDocument WHERE Id = @ObjectId



	DROP TABLE IF EXISTS #AclTemp
	DROP TABLE IF EXISTS #AllAccessDisciplines

	Select * INTO #AclTemp From [CM].[CMAcl] acl
		where ProjectId =@ProjectId and [Name] = @NextRole and Allow = 1

	INSERT INTO @AllAccessDisciplines
	EXEC CM.FetchAllUsersAccessDiscipline @ProjectId, 'JobReport.Discipline'


	Insert Into @UsersInRole
	Select usr.[Id],usr.[FullName],acl.[Name],usr.JobTitle,usr.ProfileImage From #AclTemp acl
		join CM.[User] usr on usr.Id = acl.UserId
		join @AllAccessDisciplines accDiscipline on accDiscipline.UserId = acl.UserId
		where acl.ProjectId = @ProjectId AND accDiscipline.Id = @DisciplineId

	Insert Into @UsersInRole
	Select usr.[Id],usr.[FullName],aclg.[Name],usr.JobTitle,usr.ProfileImage From #AclTemp aclg
		Left join CM.UsersGroups ugs on ugs.GroupId = aclg.GroupId
		Left join CM.UserGroup ug on ug.Id = ugs.GroupId
		join CM.[User] usr on usr.Id = ugs.UserId
		join @AllAccessDisciplines accDiscipline on accDiscipline.UserId = aclg.UserId
		where aclg.ProjectId = @ProjectId  AND accDiscipline.Id = @DisciplineId

	Select distinct Id,[FullName],JobTitle,[ProfileImage] From @UsersInRole
END

GO
/****** Object:  StoredProcedure [SGN].[FetchSignStepRoleCombo]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [SGN].[FetchSignStepRoleCombo]

@ProjectId int,
@CompanyId int,
@ObjectId int,
@NextSignRole varchar(55),
@BackSignStep bit,
@IsLastSignRole bit output

AS
BEGIN
	
	Declare @DocumentInSaveMode bit;
	Declare @IsLastRole bit;

	DECLARE @ObjectName varchar(55)
	DECLARE @SignConfigObjectName varchar(55)
	SELECT @SignConfigObjectName = CONCAT([Type],'.',[Type2]),@ObjectName = [Type] FROM CM.CMDocument WHERE Id = @ObjectId

	Set @IsLastRole = SGN.FnIsLastSignRole(@SignConfigObjectName,@NextSignRole,@ProjectId,@CompanyId);

	Select @DocumentInSaveMode = Posted From CM.CMDocument Where Id = @ObjectId
	
	IF @DocumentInSaveMode = 0
		Begin
			Set @NextSignRole = SGN.FnFirstNextSignRole(@ProjectId,@CompanyId,@SignConfigObjectName)
			IF @BackSignStep = 0
				SELECT sgnstep.Id,sgnstep.[Role],CM.AlterName(@ProjectId,@ObjectName,sgnstep.[Role],'en') AS Message FROM SGN.TVFGetPostSignSteps(@ProjectId,@CompanyId,@SignConfigObjectName) sgnstep
				WHERE (sgnstep.PostModeOrder >= SGN.FnGetSignRoleOrder(@ProjectId,@CompanyId,@SignConfigObjectName,@NextSignRole) And @IsLastRole = 0)

			ELSE
			SELECT sgnstep.Id,sgnstep.[Role],CM.AlterName(@ProjectId,@ObjectName,sgnstep.[Role],'en') AS Message FROM SGN.TVFGetBackSignSteps(@ProjectId,@CompanyId,@SignConfigObjectName) sgnstep
				WHERE (sgnstep.PostModeOrder >= SGN.FnGetSignRoleOrder(@ProjectId,@CompanyId,@SignConfigObjectName,@NextSignRole) And @IsLastRole = 0)
		END
	ELSE
		BEGIN
			IF @BackSignStep = 0
				SELECT sgnstep.Id,sgnstep.[Role],CM.AlterName(@ProjectId,@ObjectName,sgnstep.[Role],'en') AS Message FROM SGN.TVFGetPostSignSteps(@ProjectId,@CompanyId,@SignConfigObjectName) sgnstep
				WHERE (sgnstep.PostModeOrder > SGN.FnGetSignRoleOrder(@ProjectId,@CompanyId,@SignConfigObjectName,@NextSignRole) And @IsLastRole = 0)
		ELSE
			SELECT sgnstep.Id,sgnstep.[Role],CM.AlterName(@ProjectId,@ObjectName,sgnstep.[Role],'en') AS Message FROM SGN.TVFGetBackSignSteps(@ProjectId,@CompanyId,@SignConfigObjectName) sgnstep
				WHERE (sgnstep.PostModeOrder > SGN.FnGetSignRoleOrder(@ProjectId,@CompanyId,@SignConfigObjectName,@NextSignRole) And @IsLastRole = 0)
		END
	
	Set @IsLastSignRole = @IsLastRole

END

GO
/****** Object:  StoredProcedure [SGN].[GetDocumentIfUserPresentInTheSignCycle]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [SGN].[GetDocumentIfUserPresentInTheSignCycle]

@ProjectId int,
@CompanyId int,
@UsersId int,
@ObjectName varchar(55)

AS
BEGIN

	DROP TABLE IF EXISTS #SignTemp 

	SELECT ROW_NUMBER() OVER(PARTITION BY [ObjectName] , [ObjectId] ORDER BY Id ASC) AS RowNumber,Id,[ProjectId],[ObjectName],[ObjectId],[UserId],[Role],[NextRole],[NextRoleUsersId],CompanyId INTO #SignTemp FROM CM.[CMSign] sgn
			WHERE ProjectId = @ProjectId AND ObjectName = @ObjectName And (CompanyId IS NULL OR CompanyId = @CompanyId)
	Select doc.Id FROM Cm.CMDocument doc
	Join #SignTemp sgn on sgn.ObjectId = doc.Id
		WHERE sgn.UserId = @UsersId

END











GO
/****** Object:  StoredProcedure [SGN].[GetDocumentsForNextSignRoles]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [SGN].[GetDocumentsForNextSignRoles]

@ProjectId int,
@CompanyId int,
@UsersId int,
@ObjectName varchar(55),
@AclSignRoleName varchar(55)

AS
BEGIN

	DROP TABLE IF EXISTS #SignTemp

	SELECT ROW_NUMBER() OVER(PARTITION BY [ProjectId], [ObjectName] , [ObjectId], [NextRole] ORDER BY Id DESC) AS RowNumber,Id,[ProjectId],[ObjectName],[ObjectId],[NextRole],[NextRoleUsersId],CompanyId INTO #SignTemp FROM CM.[CMSign] sgn
			WHERE ProjectId = @ProjectId AND ObjectName = @ObjectName And (CompanyId IS NULL OR CompanyId = @CompanyId) 

	Select doc.* FROM Cm.CMDocument doc
	JOIN #SignTemp sgn ON sgn.ObjectId = doc.Id AND sgn.NextRole = doc.NextSignRole
	WHERE sgn.ObjectName = @ObjectName AND
	NextSignRole IN (SELECT [Role] FROM SGN.TVFGetUserSignRoles(@ProjectId,@UsersId,@AclSignRoleName,@ObjectName))
	AND (NextRoleUsersId IS NULL OR NextRoleUsersId = N'' OR @UsersId IN (SELECT VALUE FROM string_split([NextRoleUsersId],';')))
	AND sgn.RowNumber = 1

END








GO
/****** Object:  StoredProcedure [SGN].[GetDocumentsInNextSign]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [SGN].[GetDocumentsInNextSign]

@ProjectId int,
@CompanyId int,
@UsersId int,
@ObjectName varchar(55),
@AclSignRoleName varchar(55)

AS
BEGIN

	DROP TABLE IF EXISTS #SignTemp

	SELECT ROW_NUMBER() OVER(PARTITION BY [ProjectId], [ObjectName] , [ObjectId], [NextRole] ORDER BY Id DESC) AS RowNumber,Id,[ProjectId],[ObjectName],[ObjectId],[NextRole],[NextRoleUsersId],CompanyId INTO #SignTemp FROM CM.[CMSign] sgn
			WHERE ProjectId = @ProjectId AND ObjectName = @ObjectName And (CompanyId IS NULL OR CompanyId = @CompanyId) 

	Select doc.Id FROM Cm.CMDocument doc
	JOIN #SignTemp sgn ON sgn.ObjectId = doc.Id AND sgn.NextRole = doc.NextSignRole
	WHERE sgn.ObjectName = @ObjectName AND
	NextSignRole IN (SELECT [Role] FROM SGN.TVFGetUserSignRoles(@ProjectId,@UsersId,@AclSignRoleName,@ObjectName))
	AND (NextRoleUsersId IS NULL OR NextRoleUsersId = N'' OR @UsersId IN (SELECT VALUE FROM string_split([NextRoleUsersId],';')))
	AND sgn.RowNumber = 1

END




GO
/****** Object:  StoredProcedure [SGN].[GetSignRoleUsers]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [SGN].[GetSignRoleUsers]

@ProjectId as int,
@ObjectName as varchar(55),
@CompanyId as int = NULL,
@AclName as varchar(55),
@Role as varchar(55)

AS
BEGIN

	Declare @UsersInRole Table(Id int,FullName nvarchar(155),[Role] varchar(55),JobTitle NVarchar(120),[ProfileImage] varbinary(Max))


	DROP TABLE IF EXISTS #AclTemp

	Select * INTO #AclTemp From [CM].[CMAcl] acl
		where ProjectId = @ProjectId and [Name] = @AclName


	Insert Into @UsersInRole
	Select usr.[Id],usr.[FullName],sc.[Role],usr.JobTitle,usr.ProfileImage From #AclTemp acl
		join CM.CMAclItem aci on aci.AclId = acl.Id
		join CM.[User] usr on usr.Id = acl.UserId
		join CM.CMSignConfig sc on sc.Id = aci.[Value]
		where sc.ObjectName = @ObjectName and sc.ProjectId = @ProjectId and (@CompanyId IS NULl OR sc.CompanyId = @CompanyId) and sc.[Role] = @Role

	Insert Into @UsersInRole
	Select usr.[Id],usr.[FullName],[Role],usr.JobTitle,usr.ProfileImage From #AclTemp aclg
		join CM.CMAclItem aci on aci.AclId = aclg.Id
		Left join CM.UsersGroups ugs on ugs.GroupId = aclg.GroupId
		Left join CM.UserGroup ug on ug.Id = ugs.GroupId
		join CM.[User] usr on usr.Id = ugs.UserId
		join CM.CMSignConfig sc on sc.Id = aci.[Value]
		where sc.ObjectName = @ObjectName and sc.ProjectId = @ProjectId and (@CompanyId IS NULl OR sc.CompanyId = @CompanyId) and [Role] = @Role

	Select distinct Id,[FullName],[Role],JobTitle,[ProfileImage] From @UsersInRole
END

GO
/****** Object:  StoredProcedure [SGN].[HardResetDocumentSign]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [SGN].[HardResetDocumentSign]
	@ObjectId int
AS
BEGIN
	BEGIN TRY

		BEGIN TRANSACTION

		UPDATE CM.CMDocument SET [Posted] = 0,[Complete] = 0, [Accepted] = 0,[Approved]= 0,[ModifiedBy] = NULL,[ModifiedOn] = NULL,[DocumentOwnersRole] = NULL,[PostedOn] = NULL
			WHERE Id = @ObjectId

		DELETE FROM CM.[CMSign] WHERE ObjectId = @ObjectId
		
		COMMIT

	END TRY
	BEGIN CATCH
		ROLLBACK;
		IF @@TRANCOUNT > 1
			THROW 5000,'Multiple transaction detected',1		
	END CATCH
END

GO
/****** Object:  StoredProcedure [SGN].[IsLastSignRole]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [SGN].[IsLastSignRole]
@ProjectId int,
@CompanyId int,
@ObjectName varchar(55),
@SignRequestType varchar(20),
@Role varchar(55),
@Result bit = 0 output
AS
BEGIN

	IF @SignRequestType = N'Post'
		SET @Result = SGN.FnIsLastSignRoleInPostMode(@ObjectName,@Role,@ProjectId,@CompanyId)

	IF @SignRequestType = N'SendBack'
		SET @Result = SGN.FnIsLastSignRoleInSendBackMode(@ObjectName,@Role,@ProjectId,@CompanyId)

END

GO
/****** Object:  StoredProcedure [SGN].[SignDocument]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [SGN].[SignDocument]
(
	@SignRequestType varchar(55),
	@ProjectId as int,
	@UserId as int,
	@ObjectName as varchar(50),
	@SignConfigObjectName varchar(55) = null,
	@ObjectId as int,
	@Remark as nvarchar(2000),
	@NextRole as varchar(50) = NULL,
	@NextRoleUsersId  varchar(200),
	@AclCanDynamicRoleName varchar(55),
	@MachineName as nvarchar(150),
	@ActiveDirectoryName as nvarchar(250),
	@LoggedUserId as int,
	@CompanyId as int = null
)
AS
BEGIN
	-- DECLARE SECTIONS
	DECLARE @SaveMode bit;
	DECLARE @SenderRole varchar(55);
	DECLARE @ReciverRole varchar(55);
	DECLARE @SenderRoleOrder int;
	DECLARE @IsComplete bit;
	DECLARE @IsAccepted bit;
	DECLARE @IsDelete bit;
	DECLARE @IsVoid bit;
	DECLARE @ReciverRoleExist bit;
	DECLARE @UserHasSignRole int;
	DECLARE @CheckNextRoleUsersHasAclRole int;
	DECLARE @UserHasDynamicSignAcl bit;
	DECLARE @CanJumpFromRoleToDynamicNextRole varchar(800);
	DECLARE @IsLastSignRolePostMode bit;
	DECLARE @IsLastSignRoleSendBackMode bit;
	-- END DECLARE SECTION	



	IF @SignConfigObjectName IS NULL 
		SET @SignConfigObjectName = @ObjectName

	-- وضعیت های مختلف سند را در یافت میکند در ابتدای شروع و نسبت به وضعیت سند واکنش نشان میدهد
	Select @IsComplete = Complete,@IsAccepted = Accepted,@IsDelete = IsDelete,@IsVoid = IsVoid From CM.CMDocument Where Id = @ObjectId

	IF @IsComplete = 1 AND @IsAccepted = 1
		THROW 50000,'The document is completed!',1;
	IF @IsComplete = 1 AND @IsAccepted = 0
		THROW 50000,'The document is rejected!',1;
	IF @IsDelete = 1
		THROW 50000,'The document is deleted!',1;
	IF @IsVoid = 1
		THROW 50000,'The document is voided!',1;


	IF @NextRoleUsersId = N'' OR @NextRoleUsersId = ''
		SET @NextRoleUsersId = NULL

	-- بررسی میکند که سند در مود سیو می باشد یا خیر
	SET @SaveMode = SGN.FnIsDocumentInSaveMode(@ObjectId)
	SELECT @SaveMode

	IF @SaveMode = 1 
		BEGIN
			SET @SenderRole = SGN.FnFirstSignRole(@ProjectId,@CompanyId,@SignConfigObjectName)
			SET @ReciverRole = SGN.FnFirstNextSignRole(@ProjectId,@CompanyId,@SignConfigObjectName)

			IF @NextRole Is NULL OR @NextRole = N''
				Set @NextRole = @ReciverRole
		END
	ELSE
		BEGIN
			SET @SenderRole = SGN.FnGetDocumentNextSignRole(@ObjectId)
			SET @ReciverRole = @NextRole
		END

	IF @NextRole <> @ReciverRole
		SET @ReciverRole = @NextRole	

	SELECT @SenderRole SenderRole
	SELECT @ReciverRole RecieverRole
	SELECT @NextRole NextRole	


	SET @IsLastSignRolePostMode = SGN.FnIsLastSignRoleInPostMode(@SignConfigObjectName,@SenderRole,@ProjectId,@CompanyId)
	SET @IsLastSignRoleSendBackMode = SGN.FnIsLastSignRoleInSendBackMode(@SignConfigObjectName,@SenderRole,@ProjectId,@CompanyId)



	-- بررسی میکند که رول فرستنده چه اوردری دارد
	SET @SenderRoleOrder = SGN.FnGetSignRoleOrder(@ProjectId,@CompanyId,@SignConfigObjectName,@SenderRole)

		IF @SenderRoleOrder IS NULL
			THROW 50000,'Order of sender role not found',1;


	IF @SignRequestType = 'POST' OR @SignRequestType = 'SendBACK'
		BEGIN;					
							
			-- بررسی میکند که رول مقصد معتبر است یا خیر در جدول کانفیگ چنین رولی اصلا وجود دارد یا خیر
			SET @ReciverRoleExist = SGn.FnSignRoleNameExist(@ProjectId,@CompanyId,@SignConfigObjectName,@NextRole)
				IF @ReciverRoleExist = 0 AND @IsLastSignRolePostMode <> 1
					THROW 50000,'The reciver role is not exist!',1;
			-- بررسی میکند که کاربر سیستم رول مورد نظر را دارد یا خیر
			SET @UserHasSignRole = SGN.FnUserHasAcl(@ProjectId,@UserId,Concat(@ObjectName,'.',@SenderRole))

			IF @UserHasSignRole = 0 OR @UserHasSignRole IS NULL
				THROW 50000,'You don''t have access for this role',1;

			-- بررسی میکند که دریافت کننده سند آیا رول لازم را برای این موضوع دارد یا خیر
			Set @CheckNextRoleUsersHasAclRole = SGN.FnNextSignUsersHasAcl(@ProjectId,@NextRoleUsersId,Concat(@ObjectName,'.',@NextRole))

			
			IF @SenderRole = @NextRole
				THROW 50000,'Operation faild, because you want to post document to current role',1;


			
			IF @CheckNextRoleUsersHasAclRole = 0
				THROW 50000,'The selected recivers don''t have access for revice document at next role',1;
			
			-- بررسی میشود که کاربر سند را به رولی که در رده خودش است ارسال نمیکند
			

			-- سطح و طبقه یک ساین را مشخص میکند 
			IF SGN.FnGetSignRoleOrder(@ProjectId,@CompanyId,@SignConfigObjectName,@NextRole) < SGN.FnGetSignRoleOrder(@ProjectId,@CompanyId,@SignConfigObjectName,@SenderRole)  AND @SignRequestType = 'POST' 
				THROW 50000,'Operation faild, Revers posting detected',1;
	
			IF SGN.FnGetSignRoleOrder(@ProjectId,@CompanyId,@SignConfigObjectName,@NextRole) > SGN.FnGetSignRoleOrder(@ProjectId,@CompanyId,@SignConfigObjectName,@SenderRole)  AND @SignRequestType = 'SendBACK' 
				THROW 50000,'Operation faild, Revers Send back detected',1;



			-- بررسی حالت داینامیک سند در حالت پست
			IF UPPER(@SignRequestType) = 'POST'
				BEGIN
					-- بررسی میکند که میان فرستنده و گیرنده رول دیگری وجود دارد 
					DECLARE @CheckPostForDynamicPost int = 0;
					SET @CheckPostForDynamicPost = SGN.FnCheckRoleHasBetweenSenderAndRevierRole(@ProjectId,@CompanyId,@SignConfigObjectName,@SenderRole,@NextRole)

					IF @CheckPostForDynamicPost > 0
						BEGIN					
							SET @UserHasDynamicSignAcl = SGN.FnUserHasAcl(@ProjectId,@UserId,@AclCanDynamicRoleName)
							SELECT @UserHasDynamicSignAcl ACLHAS
								IF  @UserHasDynamicSignAcl IS NULL OR @UserHasDynamicSignAcl = 0
									THROW 50000,'You don''t have access for work in sign steps dynamically',1;

							SET @CanJumpFromRoleToDynamicNextRole =  SGN.FnGetRoleReqiredAcceptedBetweenSenderRoleAndReciverRole(@ProjectId,@CompanyId,@SignConfigObjectName,@ObjectId,@SenderRole,@NextRole,@SignRequestType)
								IF @CanJumpFromRoleToDynamicNextRole IS NOT NULL
									BEGIN 
										DECLARE @Temp1 varchar(55) = 'The '+@CanJumpFromRoleToDynamicNextRole+ ' role is required';
										THROW 50000,@Temp1,1;
									END
						END		
				END

			-- بررسی حالت داینامیک سند در حالت بک
			IF @SignRequestType = 'SendBack'
				BEGIN
					DECLARE @CheckPostForDynamicBack int = 0;
					SET @CheckPostForDynamicBack = SGN.FnCheckBackModeRoleHasBetweenSenderAndRevierRole(@ProjectId,@CompanyId,@SignConfigObjectName,@SenderRole,@NextRole)

					IF @CheckPostForDynamicBack > 0
						BEGIN
							SET @UserHasDynamicSignAcl = SGN.FnUserHasAcl(@ProjectId,@UserId,@AclCanDynamicRoleName)
								IF  @UserHasDynamicSignAcl IS NULL OR @UserHasDynamicSignAcl = 0
									THROW 50000,'You don''t have access for work in sign steps dynamically',1;
							SET @CanJumpFromRoleToDynamicNextRole =  SGN.FnGetRoleReqiredAcceptedBetweenSenderRoleAndReciverRole(@ProjectId,@CompanyId,@SignConfigObjectName,@ObjectId,@SenderRole,@NextRole,'back')
								IF @CanJumpFromRoleToDynamicNextRole IS NOT NULL
									BEGIN 
										DECLARE @Temp2 varchar(55) = 'The '+@CanJumpFromRoleToDynamicNextRole+ ' role is required';
										THROW 50000,@Temp2,1;
									END
						END		
				END
		END

	BEGIN TRY
		BEGIN TRANSACTION
		DECLARE @InsertedId int;
		
	
		IF (@IsLastSignRoleSendBackMode = 1 AND @SignRequestType = N'SendBACK')
			THROW 50020,'Can not send back document to first role!',1;
		
		
		IF (@IsLastSignRolePostMode = 1 AND @SignRequestType = N'POST') OR @SignRequestType = 'Reject'
			SET @NextRole = NULL

		



		INSERT INTO CM.[CMSign]
		(
			ProjectId,
			UserId,
			ObjectName,
			ObjectId,
			[Role],
			[RoleUserId],
			CreateDate,
			[Order],
			Remark,
			NextRole,
			[NextRoleUsersId],
			MachineName,
			ActiveDirectoryName,
			LoggedUserId,
			CompanyId,
			IsSeen
		)
		values
		(
			@ProjectId,
			@UserId,
			@ObjectName,
			@ObjectId,
			@SenderRole,
			@UserId,
			GETDATE(),
			@SenderRoleOrder,
			@Remark,
			@NextRole,
			@NextRoleUsersId,
			@MachineName,
			@ActiveDirectoryName,
			@LoggedUserId,
			@CompanyId,
			0
		)

		Set @InsertedId  = SCOPE_IDENTITY()


		-- اکشن گرفتن سند در حالت پست
		IF Upper(@SignRequestType) = 'POST'
			BEGIN
				UPDATE [CM].[CMSign] Set Accepted = 1 WHERE Id = @InsertedId				

				UPDATE [CM].[CMDocument] Set [DocumentOwnersRole] = @NextRole,[Posted] = 1,[PostedOn] = GETDATE(),
					ModifiedBy = @UserId,ModifiedOn = GETDATE()
					WHERE Id = @ObjectId												
				
				IF  @IsLastSignRolePostMode = 1
					BEGIN
						UPDATE CM.CMDocument Set Complete = 1 , Accepted = 1
							WHERE Id = @ObjectId
					END
			END

		-- اکشن گرفتن سند در حالت بک
		IF Upper(@SignRequestType) = 'SendBACK'
			BEGIN							
				UPDATE [CM].[CMDocument] Set [DocumentOwnersRole] = @NextRole,
					ModifiedBy = @UserId,ModifiedOn = GETDATE()
					WHERE Id = @ObjectId
			END


		-- اکشن گرفتن سند در حالت ریجکت
		IF Upper(@SignRequestType) = 'REJECT'
			BEGIN
				UPDATE [CM].[CMSign] Set Accepted = 0 WHERE Id = @InsertedId
											
				UPDATE [CM].[CMDocument] Set [DocumentOwnersRole] = @NextRole, Complete = 1 ,Accepted = 0,
					ModifiedBy = @UserId,ModifiedOn = GETDATE()
					WHERE Id = @ObjectId
			END


		SELECT 'SUCCESS' [Message]

		COMMIT

	END TRY

	BEGIN CATCH
		;RollBack
		Select ERROR_MESSAGE() [Message]

	END CATCH

END

GO
/****** Object:  StoredProcedure [TICKET].[CreateTicket]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [TICKET].[CreateTicket]
@UserId As int,
@ProjectId As int,
@CompanyId As int,
@DisciplineId As int,
@DstDisciplineId As int,
@TicketNumber As varchar(255),
@Subject As nvarchar(255),
@BreifDescription As text,
@Prirority As int
AS
BEGIN

	Begin Transaction;
	Begin Try
		Insert Into TICKET.Ticket(
			[CreatedBy],
			[ProjectId],
			[CompanyId],
			[DisciplineId],
			[DstDisciplineId],
			[TicketNumber],
			[Subject],
			[BriefDescription],
			[PrirorityId],
			[CreatedAt]
		)
		values (
			@UserId,
			@ProjectId,
			@CompanyId,
			@DisciplineId,
			@DstDisciplineId,
			@TicketNumber,
			@Subject,
			@BreifDescription,
			@Prirority,
			GETDATE()
		)
		Commit;
	End try
	Begin catch
		Rollback;
	End catch

END

GO
/****** Object:  StoredProcedure [TICKET].[DeleteTicket]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [TICKET].[DeleteTicket]
@TicketIds as [TICKET].[TicketIdsTable] ReadOnly,
@UserId int
AS
BEGIN

	Begin Transaction;
	Begin Try
		Update [TICKET].Ticket Set
			[IsDelete] = 1,
			[DeletedAt] = GetDate(),
			[DeletedBy] = @UserId		
		Where TicketId in (Select Id from @TicketIds)

		Commit;
	End Try
	Begin Catch
		RollBack;
	End Catch

END

GO
/****** Object:  StoredProcedure [TICKET].[GetAllTicket]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [TICKET].[GetAllTicket]
@ProjectId as int,
@CompanyId as int,
@UserId as int
AS
BEGIN
	Select 
		tk.[TicketId],
		tk.[TicketNumber],
		doc.Id DocumentId,
		tk.[Subject],
		tk.[BriefDescription],
		p.Id as ProjectId,
		CONCAT(p.[Name],p.[Code]) As 'Project' ,
		co.Id As CompanyId,
		co.[FullName] As Company,
		ouSource.Id as DisciplineId,
		ouTarget.Id as DstDisciplineId,
		ouSource.[Name] Discipline,
		ouTarget.[Name] as DstDiscipline,
		stat.[StatusId],
		stat.[Status],
		pri.PrirorityId,
		pri.Prirority,			
		tk.[IsDelete],
		cu.FullName as CreatedBy,
		tk.CreatedAt as CreatedDate,
		uu.FullName as UpdatedBy,
		tk.UpdateAt as UpdatedDate,
		mu.[FullName] As DocModifiedUser,
		doc.ModifiedOn As DocModifiedDate,
		doc.[Type],
		doc.DocumentOwnersRole,
		sgn.NextRoleUsersId,
		nu.[FullName] As NextRoleUser,
		doc.Posted,
		doc.PostedOn,
		doc.Accepted,
		doc.Approved,
		doc.Complete

		
	From CM.[CMSign] sgn
	Right join CM.CMDocument doc on doc.Id = sgn.ObjectId
    Left join Ticket.Ticket tk on tk.TicketNumber = doc.ReportNo
	join CM.Project p on p.Id = tk.ProjectId
	join CM.Company co on co.Id = tk.CompanyId
	join CM.OrganizationUnit ouSource on ouSource.Id = tk.DisciplineId
	join CM.OrganizationUnit ouTarget on ouTarget.Id = tk.DstDisciplineId
	join TICKET.Status stat on stat.StatusId = tk.StatusId
	join Ticket.Prirority pri on pri.PrirorityId = tk.PrirorityId
	Left join CM.[User] nu on nu.Id = sgn.NextRoleUsersId
	Left join CM.[User] cu on cu.Id = tk.CreatedBy
	Left join CM.[User] uu on uu.Id = tk.UpdatedBy
	Left join CM.[User] mu on mu.Id = doc.ModifiedBy
	 
	where tk.IsDelete = 0 and tk.CreatedBy = @UserId and doc.Posted = 0 and co.Id=@CompanyId
	order by CreatedAt desc,PrirorityId desc
	
END
GO
/****** Object:  StoredProcedure [TICKET].[SaveAttachment]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
CREATE PROCEDURE [TICKET].[SaveAttachment]

@ProjectId as int,
@UserId as int,
@ObjectName as nvarchar(255),
@ObjectId as int,
@Files as TICKET.FileItemType READONLY

AS
BEGIN
	Begin Transaction
	Begin TRY
	  --Merge for FileTicketAttachment table
	  MERGE TICKET.[ftAttachmentTicket] as t
		USING @Files As s 
		ON (t.[name] = s.[FileName] )
		WHEN NOT MATCHED By target THEN
			Insert([name],[file_stream])
			Values(s.[FileName],s.[Content]);

	 -- Merge for Attachment table
		MERGE CM.[CMAttachments] as t
		USING (
			Select 
				fat.Id As Id,
				@ProjectId As ProjectId,
				@ObjectName As ObjectName,
				@ObjectId As ObjectId,
				tft.[stream_id] As stream_id,
				tft.[creation_time] As CreatedDate,
				@UserId As CreatedUserId,
				0 As IsDelete,
				fat.[CustomType] As CustomType,
				fat.[FileType] As FileType,
				fat.[FileName] As [FileName],
				fat.[Remark] As Remark
				From TICKET.ftAttachmentTicket tft
				join @Files fat on fat.[FileName] = tft.[name]
		) s 

		ON (t.[Id] = s.[Id] )

		WHEN NOT MATCHED By target THEN
			Insert(ProjectId,ObjectName,ObjectId,stream_id,CreatedDate,CreatedUserId,IsDelete,CustomType,FileType,[FileName],Remark)
			Values(s.ProjectId,s.ObjectName,s.ObjectId,s.stream_id,s.CreatedDate,s.CreatedUserId,0,s.CustomType,s.FileType,s.[FileName],s.Remark)

		WHEN MATCHED THEN
			UPDATE Set
			t.[ProjectId] = s.[ProjectId],
			t.[ObjectName] = s.[ObjectName],
			t.[ObjectId] = s.[ObjectId],
			t.[CustomType] = s.[CustomType],
			t.[FileType] = s.[FileType],
			t.[FileName] = s.[FileName],
			t.[Remark] = s.[Remark]	
	
		WHEN NOT MATCHED BY SOURCE And t.ObjectId = @ObjectId THEN
			Update Set
				t.[IsDelete] = 1,
				t.[DeletedDate] = GetDate(),
				t.[DeletedUserId] = @UserId,
				t.[DeletedOn] = t.[DeletedDate],
				t.[DeletedBy] = t.[DeletedUserId];			

		COMMIT
	END TRY
	BEGIN CATCH		
		ROLLBACK
	END CATCH
END

GO
/****** Object:  StoredProcedure [TICKET].[TicketInboxList]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [TICKET].[TicketInboxList]
@ProjectId as int,
@CompanyId as int,
@UserId as int
AS
BEGIN
	Declare  @UserRole as Table(ObjectName varchar(55),[Role] varchar(55),[Allow] int null);

	-- Cte for get acl result from user
	;With CteAclX
	As(
		Select * From Cm.Acl where acl.ProjectId = @ProjectId and acl.UserId= @UserId
	)Insert into @UserRole
	Select sc.[Objectname],sc.[Role],Allow From CteAclX cax
		join CM.AclItem acli on acli.AclId = cax.Id
		join CM.CMSignConfig sc on sc.Id = acli.[Value]
		join CM.[CMSign] sgn1 on sgn1.ObjectName = sc.ObjectName


	-- Cte for get result from user group
	;With CteUsersGroups
	As(
		Select * From Cm.UsersGroups where UserId = @UserId
	)Insert INTO @UserRole
	select sc.[Objectname],sc.[Role],Allow from CteUsersGroups cugs
	join CM.Acl acl on acl.GroupId = cugs.GroupId
	join CM.AclItem acli on acli.AclId = acl.Id
	join CM.CMSignConfig sc on sc.Id = acli.[Value]

	Select
		tk.[TicketId],
		tk.[TicketNumber],
		doc.Id DocumentId,
		tk.[Subject],
		tk.[BriefDescription],
		p.Id as ProjectId,
		CONCAT(p.[Name],p.[Code]) As 'Project' ,
		co.Id As CompanyId,
		co.[FullName] As Company,
		ouSource.Id as DisciplineId,
		ouTarget.Id as DstDisciplineId,
		ouSource.[Name] Discipline,
		ouTarget.[Name] as DstDiscipline,
		stat.[StatusId],
		stat.[Status],
		pri.PrirorityId,
		pri.Prirority,			
		tk.[IsDelete],
		cu.FullName as CreatedBy,
		tk.CreatedAt as CreatedDate,
		uu.FullName as UpdatedBy,
		tk.UpdateAt as UpdatedDate,
		mu.[FullName] As DocModifiedUser,
		doc.ModifiedOn As DocModifiedDate,
		doc.[Type],
		doc.DocumentOwnersRole,
		sgn2.NextRoleUsersId,
		su.[FullName] As Sender,
		doc.Posted,
		doc.PostedOn,
		doc.Accepted,
		doc.Approved,
		doc.Complete		
	 From @UserRole ur
		join CM.[CMSign] sgn1 on sgn1.ObjectName = ur.ObjectName
		join CM.[CMSign] sgn2 on sgn2.NextRole = ur.[Role]
		join CM.CMDocument doc on doc.Id = sgn2.ObjectId
		join TICKET.Ticket tk on tk.TicketNumber = doc.ReportNo
		join CM.Project p on p.Id = tk.ProjectId
		join CM.Company co on co.Id = tk.CompanyId
		join CM.OrganizationUnit ouSource on ouSource.Id = tk.DisciplineId
		join CM.OrganizationUnit ouTarget on ouTarget.Id = tk.DstDisciplineId
		join TICKET.[Status] stat on stat.StatusId = tk.StatusId
		join TICKET.[Prirority] pri on pri.PrirorityId = tk.PrirorityId
		join CM.[User] cu on cu.Id = tk.CreatedBy
		Left join CM.[User] uu on uu.Id = tk.UpdatedBy
		Left join CM.[User] mu on mu.Id = doc.ModifiedBy
		Left join CM.[User] su on su.Id = sgn2.RoleUserId
	WHERE sgn2.NextRoleUsersId IS NULL OR sgn2.NextRoleUsersId = @UserId

END
GO
/****** Object:  StoredProcedure [TICKET].[TicketInboxList2]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [TICKET].[TicketInboxList2]
@ProjectId as int,
@CompanyId as int,
@UserId as int
AS
BEGIN
	Declare  @UserRole as Table(ObjectName varchar(55),[Role] varchar(55),[Allow] int null);

	-- Cte for get acl result from user
	;With CteAclX
	As(
		Select * From Cm.Acl where acl.ProjectId = @ProjectId and acl.UserId= @UserId
	)Insert into @UserRole
	Select sc.[Objectname],sc.[Role],Allow From CteAclX cax
		join CM.AclItem acli on acli.AclId = cax.Id
		join CM.SignConfig sc on sc.Id = acli.[Value]
		join CM.[Sign] sgn1 on sgn1.ObjectName = sc.ObjectName


	-- Cte for get result from user group
	;With CteUsersGroups
	As(
		Select * From Cm.UsersGroups where UserId = @UserId
	)Insert INTO @UserRole
	select sc.[Objectname],sc.[Role],Allow from CteUsersGroups cugs
	join CM.Acl acl on acl.GroupId = cugs.GroupId
	join CM.AclItem acli on acli.AclId = acl.Id
	join CM.SignConfig sc on sc.Id = acli.[Value]

	Select
		tk.[TicketId],
		tk.[TicketNumber],
		doc.Id DocumentId,
		tk.[Subject],
		tk.[BriefDescription],
		p.Id as ProjectId,
		CONCAT(p.[Name],p.[Code]) As 'Project' ,
		co.Id As CompanyId,
		co.[FullName] As Company,
		ouSource.Id as DisciplineId,
		ouTarget.Id as DstDisciplineId,
		ouSource.[Name] Discipline,
		ouTarget.[Name] as DstDiscipline,
		stat.[StatusId],
		stat.[Status],
		pri.PrirorityId,
		pri.Prirority,			
		tk.[IsDelete],
		cu.FullName as CreatedBy,
		tk.CreatedAt as CreatedDate,
		uu.FullName as UpdatedBy,
		tk.UpdateAt as UpdatedDate,
		mu.[FullName] As DocModifiedUser,
		doc.ModifiedOn As DocModifiedDate,
		doc.[Type],
		doc.NextSignRole,
		sgn2.NextRoleUserId,
		su.[FullName] As Sender,
		doc.Posted,
		doc.PostedOn,
		doc.Accepted,
		doc.Approved,
		doc.Complete		
	 From @UserRole ur
		join CM.[Sign] sgn1 on sgn1.ObjectName = ur.ObjectName
		join CM.[Sign] sgn2 on sgn2.NextRole = ur.[Role]
		join CM.Document doc on doc.Id = sgn2.ObjectId
		join TICKET.Ticket tk on tk.TicketNumber = doc.ReportNo
		join CM.Project p on p.Id = tk.ProjectId
		join CM.Company co on co.Id = tk.CompanyId
		join CM.OrganizationUnit ouSource on ouSource.Id = tk.DisciplineId
		join CM.OrganizationUnit ouTarget on ouTarget.Id = tk.DstDisciplineId
		join TICKET.[Status] stat on stat.StatusId = tk.StatusId
		join TICKET.[Prirority] pri on pri.PrirorityId = tk.PrirorityId
		join CM.[User] cu on cu.Id = tk.CreatedBy
		Left join CM.[User] uu on uu.Id = tk.UpdatedBy
		Left join CM.[User] mu on mu.Id = doc.ModifiedBy
		Left join CM.[User] su on su.Id = sgn2.NextRoleUserId
	WHERE sgn2.NextRoleUserId IS NULL OR sgn2.NextRoleUserId = @UserId

END
GO
/****** Object:  StoredProcedure [TICKET].[TicketSentList]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [TICKET].[TicketSentList]
@ProjectId as int,
@CompanyId as int,
@UserId as int
AS
BEGIN
	Select 
		tk.[TicketId],
		tk.[TicketNumber],
		doc.Id DocumentId,
		tk.[Subject],
		tk.[BriefDescription],
		p.Id as ProjectId,
		CONCAT(p.[Name],p.[Code]) As 'Project' ,
		co.Id As CompanyId,
		co.[FullName] As Company,
		ouSource.Id as DisciplineId,
		ouTarget.Id as DstDisciplineId,
		ouSource.[Name] Discipline,
		ouTarget.[Name] as DstDiscipline,
		stat.[StatusId],
		stat.[Status],
		pri.PrirorityId,
		pri.Prirority,			
		tk.[IsDelete],
		cu.FullName as CreatedBy,
		tk.CreatedAt as CreatedDate,
		uu.FullName as UpdatedBy,
		tk.UpdateAt as UpdatedDate,
		mu.[FullName] As DocModifiedUser,
		doc.ModifiedOn As DocModifiedDate,
		doc.[Type],
		doc.NextSignRole,
		sgn.NextRoleUserId,
		nu.[FullName] As NextRoleUser,
		doc.Posted,
		doc.PostedOn,
		doc.Accepted,
		doc.Approved,
		doc.Complete

		
	From CM.[Sign] sgn
	join CM.Document doc on doc.Id = sgn.ObjectId
	join Ticket.Ticket tk on tk.TicketNumber = doc.ReportNo
	join CM.Project p on p.Id = tk.ProjectId
	join CM.Company co on co.Id = tk.CompanyId
	join CM.OrganizationUnit ouSource on ouSource.Id = tk.DisciplineId
	join CM.OrganizationUnit ouTarget on ouTarget.Id = tk.DstDisciplineId
	join TICKET.Status stat on stat.StatusId = tk.StatusId
	join Ticket.Prirority pri on pri.PrirorityId = tk.PrirorityId
	Left join CM.[User] nu on nu.Id = sgn.NextRoleUserId
	Left join CM.[User] cu on cu.Id = tk.CreatedBy
	Left join CM.[User] uu on uu.Id = tk.UpdatedBy
	Left join CM.[User] mu on mu.Id = doc.ModifiedBy
	 
	where tk.IsDelete = 0 and tk.CreatedBy = @UserId and sgn.RoleUserId = @UserId and doc.Posted = 1 and co.Id=@CompanyId
	order by CreatedAt desc,PrirorityId desc
	
END
GO
/****** Object:  StoredProcedure [TICKET].[UpdateTicket]    Script Date: 2/9/2022 5:49:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [TICKET].[UpdateTicket] 
@TicketId int,
@TicketNumber varchar(255),
@Subject nvarchar(255),
@BriefDescription text,
@ProjectId int,
@CompanyId int,
@DisciplineId int,
@DstDisciplineId int,
@StatusId int,
@PrirorityId int,
@UpdatedBy int
AS
BEGIN

Begin Transaction
	Begin Try
		Update TICKET.Ticket Set
		[Subject] = @Subject,
		[BriefDescription] = @BriefDescription,
		[ProjectId] = @ProjectId,
		[CompanyId] = @CompanyId,
		[DisciplineId] = @DisciplineId,
		[DstDisciplineId] = @DstDisciplineId,
		[StatusId] = @StatusId,
		[PrirorityId] = @PrirorityId,
		[UpdateAt] = GETDATE(),
		[UpdatedBy] = @UpdatedBy
		where 
		[TicketId] = @TicketId and
		[TicketNumber] = @TicketNumber
		Commit
	End Try
	Begin Catch
		Select ERROR_MESSAGE() as ErrorMessage
		Rollback
	End Catch
END

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'For Form 819-1 Has 3 Parameter => High Voltage Cable,Medium Voltage Cable,Low Voltage & Control Cable' , @level0type=N'SCHEMA',@level0name=N'QCEL', @level1type=N'TABLE',@level1name=N'CF', @level2type=N'COLUMN',@level2name=N'VoltageCableType'
GO
USE [master]
GO
ALTER DATABASE [CMIS] SET  READ_WRITE 
GO
