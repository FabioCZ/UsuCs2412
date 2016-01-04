Awesome Typing Tutor v1.0
(c) Fabio Gottlicher, A01647928


My custom feature is ability to load a custom prompt from a file and save results to a file.
To load a custom prompt, user should select File->SelectPromptFile and then click From File Radio button (this button is not enabled if a prompt is not selected). The prompt length is limited to 300characters ( customPromptMaxLength variable). User should select a .txt file.
To save results, user should select File->Save Results and the latest prompt results are saved to a .txt file of choice.
To implement this feature, I used the openFileDialog and saveFileDialog component. The menustrip component also helped to make it pretty.
Also, the buttons are color with a random color, which I thought would be pretty disco and awesome

GUI components used:
-button - all the keys
-rich text box - the typing box
-group box - used to group radio buttons
-label - shows a bunch of text stuff
-radio button - prompt selection
-menu strip - allows saving/opening, help and others
-open file dialog - allows opening of a custom prompt
-save file dialog - allows saving of results