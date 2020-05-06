bulk insert [dbo].[STOCK_INFO]
from 'C:\Users\rockm\Google Drive\Văn Bằng 2\Cơ sở dữ liệu\DATABASE\Company\STOCK\AAA STOCK 2011-2019.csv'
with (fieldterminator=',',rowterminator='\n',firstrow=2);