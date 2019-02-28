USE Permission

IF NOT EXISTS (SELECT 1
               FROM   sysobjects
               WHERE  id = Object_id('User')
                      AND type = 'U')
  BEGIN
      CREATE TABLE [User]
        (
           [ID]           UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT Newsequentialid(),
           [Name]         NVARCHAR(128),
           [EnglishName]  VARCHAR(128),
           [Phone]        VARCHAR(16),
           [Email]        VARCHAR(128),
           [Password]    VARCHAR(256),
           [Salt]         VARCHAR(128),
           [Type]         INT NOT NULL DEFAULT(0),
           [Remark]       VARCHAR(256),
           [Disabled]     BIT NOT NULL DEFAULT(0),
           [CreateAt]     DATETIME NOT NULL,
           [CreateBy]     VARCHAR(128),
           [LastUpdateAt] DATETIME NOT NULL,
           [LastUpdateBy] VARCHAR(128)
        )
  END 
