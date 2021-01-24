module Katjanewski.Views.Footer

open Fable.React
open Fable.React.Props


let footer model dispatch =
  div [ Class "w-full py-4 flex flex-col items-center justify-center" ]
    [ a [ Class "hover:text-blue-300"
          Href "https://www.notion.so/Impressum-1604d7b040c04f0c8083da6af93d6d54"
          Target "_blank"
        ]
        [ "Impressum" |> ofString ]
      div [ ] [ str "Copyright © Heimeshoff IT"] ]  
