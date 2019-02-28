IF NOT EXISTS (SELECT 1
               FROM   sysdatabases
               WHERE  name = 'Permission')
  BEGIN
      CREATE DATABASE Permission
  END 
