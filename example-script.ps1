echo "`nThis is a user name folder generator.`n"
# Create a folder if it does not already exist
if (Get-Item -Path Names -ErrorAction Ignore) {
    echo "Main folder already exists `n"
    cd Names
}
else {
    echo "Creating the name folder. `n"
    md Names
    cd Names
}

$Name = Read-Host -Prompt 'Input your name: '

if (Get-Item -Path $Name -ErrorAction Ignore) {
    echo "`nName already exists in main folder... `n"
    cd $Name
}
else {
    echo "`nCreating $Name folder"
    md $Name
    cd .\$Name
}

echo ($Name)  > nameofuser.txt
echo "`nName of user has been saved in a text file"

# Displays sub folder text file content
echo "`nContent of the  text file: `n"
cat nameofuser.txt

# move back to parent directory
cd ../..