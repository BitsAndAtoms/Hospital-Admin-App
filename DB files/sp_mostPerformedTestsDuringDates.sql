USE [CS6232-g4]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sp_mostPerformedTestsDuringDates]
		@BeginDate = '2019-01-27',
		@EndDate = '2019-04-27'

SELECT	'Return Value' = @return_value

GO
