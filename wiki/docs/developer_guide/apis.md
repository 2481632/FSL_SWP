# APIs

## Open-Meteo

Since GPS coordinates provide only a very inaccurate altitude value, we use the [Open-Meteo Elevation API](https://open-meteo.com/en/docs/elevation-api) to determine the elevation of the current location. The query requires latitude and longitude, and the API returns the elevation at the given position.

## Pegelonline

Using [Pegelonline](https://www.pegelonline.wsv.de/webservice/guideRestapi), we can retrieve a list of all available water gauge stations along with their coordinates and IDs. This allows us to calculate which station is closest to the current location and subsequently request the measured water level values for that station using its ID.

## Mock API

For testing and development purposes, we designed a minimal mock API built with Python Flask. It simply returns the value of a fictional gauge station in the style of Pegelonline, allowing any desired water level to be simulated during development. It can easily be swapped out for the real API when needed.