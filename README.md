# .net-WebBruteForcer
Simple .net Web BruteForcer for education and pentesting purposes
## Screenshots
![v1.0](https://github.com/m4ndingo/.net-WebBruteForcer/blob/main/screenshots/main_v1.1.png)
## Changelog

### v1.1

- Logging added
	- Newtonsoft JSON library added
	- Now, each scan creates the "logs" folder if not exists
	- And for each hostname bruteforced, the following files are created:
		- <hostname>-bf_results.txt   # log in plain text
		- <hostname>-bf_results.json  # log in json format
		- <hostname>-bf_config.json   # bruteforce configuration 
- Fixed function download_url_noSSL (was incomplete)
- Moved "method" options to main menu
- Added option to open current dictionary file in text editor
- Fixed URL control width when resizing
- Code & layout refactoring
- Added option to hide responses with a number of lines
- Added option for not breaking on errors
- Added panel with workers state (green-running, cyan-data ready, red-stopped, gray-idle)
