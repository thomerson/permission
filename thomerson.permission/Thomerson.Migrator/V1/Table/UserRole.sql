USE Permission

IF NOT EXISTS (SELECT 1
               FROM   sysobjects
               WHERE  id = Object_id('UserRole')
                      AND type = 'U')
  BEGIN
      CREATE TABLE [UserRole]
        (
           [ID]           UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT Newsequentialid(),
           [UserId]       UNIQUEIDENTIFIER NOT NULL,
           [RoleId]       UNIQUEIDENTIFIER NOT NULL,
           [Disabled]     BIT NOT NULL DEFAULT(0),
           [CreateAt]     DATETIME NOT NULL,
           [CreateBy]     VARCHAR(128),
           [LastUpdateAt] DATETIME NOT NULL,
           [LastUpdateBy] VARCHAR(128)
        )
  END 
