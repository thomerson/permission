
IF NOT EXISTS (SELECT 1
               FROM   sysobjects
               WHERE  id = Object_id('RoleRight')
                      AND type = 'U')
  BEGIN
      CREATE TABLE [RoleRight]
        (
           [ID]           UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT Newsequentialid(),
           [RoleId]       UNIQUEIDENTIFIER NOT NULL,
           [RightId]      UNIQUEIDENTIFIER NOT NULL,
           [Disabled]     BIT NOT NULL DEFAULT(0),
           [CreateAt]     DATETIME NOT NULL,
           [CreateBy]     VARCHAR(128),
           [LastUpdateAt] DATETIME NOT NULL,
           [LastUpdateBy] VARCHAR(128)
        )
  END 
