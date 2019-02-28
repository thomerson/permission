USE Permission

IF NOT EXISTS (SELECT 1
               FROM   sysobjects
               WHERE  id = Object_id('Right')
                      AND type = 'U')
  BEGIN
      CREATE TABLE [Right]
        (
           [ID]           UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT Newsequentialid(),
           [Name]         NVARCHAR(128),
           [Identifier]   VARCHAR(128),
           [Type]         INT NOT NULL DEFAULT(0),
           [ParentId]     UNIQUEIDENTIFIER,
           [Remark]       VARCHAR(256),
           [Disabled]     BIT NOT NULL DEFAULT(0),
           [CreateAt]     DATETIME NOT NULL,
           [CreateBy]     VARCHAR(128),
           [LastUpdateAt] DATETIME NOT NULL,
           [LastUpdateBy] VARCHAR(128)
        )
  END 
