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

--? Use Join statements
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


--8 COUNT and GROUPBY
SELECT a.Title, COUNT(s.SongId)
FROM Song s
JOIN Album a ON s.AlbumId = a .AlbumId
GROUP BY s.AlbumId;

--12 MAX 
SELECT a.Title, MAX(a.AlbumLength)
FROM Album a;







