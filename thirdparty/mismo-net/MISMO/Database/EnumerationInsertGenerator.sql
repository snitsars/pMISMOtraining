if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EnumerationCreator]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EnumerationCreator]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.usp_EnumerationCreator
(
	@tableName varchar(64)
)
AS

declare @dynsql nvarchar(3000)

set @dynsql = 'select ''insert into ' + @tableName  + ' ([Id], [Name], [EnumeratedName], [Description]) values ('' + Cast([Id] as varchar(3)) + '', '''''' + [Name] + '''''', '''''' + [EnumeratedName] + '''''', '''''' + [Description] + '''''')'' as insertSQL from ' + @tableName + ' where [Description] is not null union select ''insert into ' + @tableName  + ' ([Id], [Name], [EnumeratedName], [Description]) values ('' + Cast([Id] as varchar(3)) + '', '''''' + [Name] + '''''', '''''' + [EnumeratedName] + '''''', null)'' as insertSQL from ' + @tableName + ' where [Description] is null'

execute sp_executesql @dynsql

RETURN 

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

