module App

open Elmish
open Elmish.React
open Fable.Core.JsInterop

open Cinema

importAll "./style.css"


Program.mkSimple State.init State.update View.render
|> Program.withReactSynchronous "elmish-app"
#if DEBUG
|> Program.withConsoleTrace
#endif
|> Program.run