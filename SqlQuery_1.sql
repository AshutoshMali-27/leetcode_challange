 Rising Temperature

 able: Weather

+---------------+---------+
| Column Name   | Type    |
+---------------+---------+
| id            | int     |
| recordDate    | date    |
| temperature   | int     |
+---------------+---------+
id is the column with unique values for this table.
This table contains information about the temperature on a certain day.
 

--Write a solution to find all dates Id with higher temperatures compared to its previous dates (yesterday).

--Return the result table in any order.

--The result format is in the following example.



WITH WeatherWithPrevious AS (
    SELECT
        w1.id AS id,
        w1.recordDate AS date,
        w1.temperature AS temperature,
        w2.temperature AS previous_temperature
    FROM Weather w1
    LEFT JOIN Weather w2
    ON w1.recordDate = DATE_ADD(w2.recordDate, INTERVAL 1 DAY)
)

SELECT id
FROM WeatherWithPrevious
WHERE previous_temperature IS NOT NULL AND temperature > previous_temperature;
