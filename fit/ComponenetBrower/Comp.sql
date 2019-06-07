--Insert image data into the image filed of the row/record
INSERT INTO Components (image)
SELECT BulkColumn FROM OPENROWSET(Bulk'C:\componentImages\AOC 27B1H Full HD.jpg', SINGLE_BLOB) AS BLOB
WHERE Id = 100;

update Components
SET Image = (SELECT BulkColumn FROM OPENROWSET(Bulk'C:\componentImages\MSI Optix MAG241C Gaming Monitor.jpg', SINGLE_BLOB) AS BLOB)
WHERE Id = 100;

update Components
SET Image = (SELECT BulkColumn FROM OPENROWSET(Bulk'C:\componentImages\SAMSUNG C24F396 Full HD Curved Monitor.jpg', SINGLE_BLOB) AS BLOB)
WHERE Id = 110;

update Components
SET Image = (SELECT BulkColumn FROM OPENROWSET(Bulk'C:\componentImages\DELL SE2717H Full Led Monitor.jpg', SINGLE_BLOB) AS BLOB)
WHERE Id = 120;

update Components
SET Image = (SELECT BulkColumn FROM OPENROWSET(Bulk'C:\componentImages\AOC 27B1H Full HD.jpg', SINGLE_BLOB) AS BLOB)
WHERE Id = 130;

