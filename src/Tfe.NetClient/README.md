https://github.com/hashicorp/go-tfe
https://app.quicktype.io/?l=csharp



| Implemented  | URL                                              | HTTP Verb | Description                                 |
|------------- |--------------------------------------------------|-----------|---------------------------------------------|
| [x]          | /organizations/{org}/workspaces/{workspace_name} | GET       | get workspace id                            |
| [x]          | /runs                                            | POST      | plan a workspace execution                  |
| [x]          | /runs/{run_id}                                   | GET       | get run status                              |
| [x]          | /runs/{run_id}/actions/apply                     | POST      | apply a planned workspace execution         |
| [x]          | /organizations/{org}/ssh-keys                    | GET       | get SSH keys                                |
| [x]          | /organizations/{org}/workspaces                  | POST      | create workspace                            |
| []          | /organizations/{org}/teams                       | GET       | query TFE team                              |
| []          | /organizations/{org}/teams                       | POST      | create TFE team                             |
| []          | /team-workspaces                                 | POST      | assign team with workspace with level       |
| [x]          | /vars                                            | POST      | attach a value to a workspace (like tfvars) |
