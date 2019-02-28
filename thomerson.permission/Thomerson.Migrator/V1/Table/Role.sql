USE Permission

IF NOT EXISTS (SELECT 1
               FROM   sysobjects
               WHERE  id = Object_id('Role')
                      AND type = 'U')
  BEGIN
      CREATE TABLE [Role]
        (
           [ID]           UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT Newsequentialid(),
           [Name]         NVARCHAR(128),
           [Remark]       VARCHAR(128),
           [Disabled]     BIT NOT NULL DEFAULT(0),
           [CreateAt]     DATETIME NOT NULL,
           [CreateBy]     VARCHAR(128),
           [LastUpdateAt] DATETIME NOT NULL,
           [LastUpdateBy] VARCHAR(128)
        )
  END 
