-- 1 Get everything in Genre
SELECT * 
FROM Genre;

-- 2 Insert artist into Artist
INSERT INTO Artist 
VALUES(null, "Cohort 26", 2018);

INSERT INTO Artist
(ArtistName, YearEstablished)
VALUES
("Led Zeppelin", 1968);

SELECT *
FROM Artist
WHERE ArtistName = "Led Zeppelin"
OR ArtistName LIKE "Coh%";

--3 Insert album by Artist
INSERT INTO Album
SELECT null, 
"Back-End Blues", 
"8/30/2018", 
54321,
r.LabelId,
a.ArtistId,
g.GenreId
FROM RecordLabel r, Artist a, Genre g
WHERE r.LabelName = "American" 
AND a.ArtistName = "Cohort 26"
AND g.Label = "Blues";

--4 Insert songs into album 
INSERT INTO Song
SELECT null,
"Confusion in the Key of C#",
123,
"8/30/2018",
g.GenreId,
a.ArtistId,
al.AlbumId
FROM Genre g, Artist a, Album al
WHERE g.Label = "Blues"
AND a.ArtistName = "Cohort 26"
AND al.Title = "Back-End Blues";

INSERT INTO Song
SELECT null,
"Database 2: The SQL",
234,
"8/30/2018",
g.GenreId,
a.ArtistId,
al.AlbumId
FROM Genre g, Artist a, Album al
WHERE g.Label = "Blues"
AND a.ArtistName = "Cohort 26"
AND al.Title = "Back-End Blues";

--5 Left Join and Where
SELECT s.Title, ar.ArtistName, al.Title
FROM Song s
LEFT JOIN Artist ar ON s.ArtistId = ar.ArtistId
LEFT JOIN Album al ON s.AlbumId = al.AlbumId
WHERE ar.ArtistName = "Cohort 26";

--6 More Left Join
SELECT s.Title as "Song", 
s.SongLength as "Duration", 
al.Title as "Album", 
g.Label as "Genre"
FROM Song s
LEFT JOIN Album al ON s.AlbumId = al.AlbumId
LEFT JOIN Genre g ON s.GenreId = g.GenreId;

--7 Filtered Left join
SELECT s.Title as "Song", 
s.SongLength as "Duration", 
al.Title as "Album", 
g.Label as "Genre"
FROM Song s
LEFT JOIN Album al ON s.AlbumId = al.AlbumId
LEFT JOIN Genre g ON s.GenreId = g.GenreId
WHERE s.SongLength >= 250;

--8 COUNT and GROUPBY
SELECT a.Title, COUNT(s.SongId)
FROM Song s
JOIN Album a ON s.AlbumId = a.AlbumId
GROUP BY s.AlbumId;

--9
SELECT ar.ArtistName as "Artist", COUNT(s.SongId) as "Number of Songs"
FROM Artist ar
JOIN Song s ON ar.ArtistId = s.ArtistId
GROUP BY s.ArtistId;

--10
SELECT g.Label as "Genre",
COUNT(s.Title) as "Number of Songs"
FROM Genre g
LEFT JOIN Song s ON s.GenreId = g.GenreId
GROUP BY s.GenreId;

--11
SELECT g.Label as "Genre",
COUNT(DISTINCT ar.ArtistId) as "Number of Artists"
FROM Genre g
LEFT JOIN Album al on al.GenreId = g.GenreId
LEFT JOIN Artist ar on ar.ArtistId = al.ArtistId
GROUP BY g.Label;
--OR
SELECT g.Label as "Genre",
COUNT(DISTINCT ar.ArtistId) as "Number of Artists"
FROM Genre g
JOIN Album al on al.GenreId = g.GenreId
JOIN Artist ar on ar.ArtistId = al.ArtistId
GROUP BY al.GenreId;


--12 MAX 
SELECT a.Title, MAX(a.AlbumLength)
FROM Album a;

--13
SELECT s.Title, MAX(s.SongLength), a.Title
FROM Song s;

--14
SELECT s.Title, MAX(s.SongLength), a.Title
FROM Song s
JOIN Album a ON s.AlbumId = a.AlbumId;


SELECT Album.Title, Song.Title
FROM Album
LEFT JOIN Song
ON Song.AlbumId = Album.AlbumId;

SELECT 
s.Title as "Song", 
a.Title as "Album"
FROM Song s
LEFT JOIN Album a
ON s.AlbumId = a.AlbumId;

--CHALLENGE
SELECT al.Title as "Album with most songs",
COUNT(s.SongId)
FROM Album al
JOIN Song s WHERE s.AlbumId = al.AlbumId
GROUP BY s.AlbumId
ORDER BY COUNT(s.SongId) DESC
LIMIT 3;

SELECT g.Label as "Genre with most songs",
COUNT(s.SongId)
FROM Genre g
JOIN Song s WHERE s.GenreId = g.GenreId
GROUP BY s.GenreId
ORDER BY COUNT(s.SongId) DESC
LIMIT 3;

SELECT r.LabelName as "Record with most albums",
COUNT(a.AlbumId)
FROM RecordLabel r
JOIN Album a WHERE a.LabelId = r.LabelId
GROUP BY a.LabelId
ORDER BY COUNT(a.AlbumId) DESC
LIMIT 3;










