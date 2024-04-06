PRINT 'Seeding Core Data in to ' + DB_NAME()
DECLARE @dbn VARCHAR(150) = DB_NAME()

SET NOCOUNT ON 

PRINT 'Seeding Test Data'

:r .\TestData\Blog.sql
:r .\TestData\Person.sql
