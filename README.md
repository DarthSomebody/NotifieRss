# NotifieRss

## About
This software can be used for automatically reading user-defined keywords from RSS-feeds. If the keyword is found in the feed and the entry in the feed was created after the software started the task, the URL to the new RSS entry will automatically open in your default browser and (optionally) a local file you selected will open as well.

## Requirements
The latest .Net-Framework is required to run the software.

## How to use it
Upon starting, the software will minimize to the tray. Double-click the tray icon to open the form. There you can add, remove, start and stop the tasks you want.

#### Example
URL: https://jaiminisbox.com/reader/feeds/rss
Keyword: One Piece
File: C:\Music\WeAre.mp3
Autorun: true

Upon clicking "Add Task", the task will be added to the task list. Because autorun was set to true, the task will automatically be started now and whenever you launch the software.
If the feed from the given URL now has a new entry that contains the keyword "One Piece", the URL to this entry will open in your default browser and "WeAre.mp3" will open with the default software for mp3-files.