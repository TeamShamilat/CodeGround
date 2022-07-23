
commit() {
  git add .
  git commit -m "update"
  git push
}

amend() {
 git add .
 git commit --amend -m "amend" 
 git push --force
}

push() {
  git push
}

force_push() {
   git push --force 
}

"$@"

# usage
# bash git.sh commit