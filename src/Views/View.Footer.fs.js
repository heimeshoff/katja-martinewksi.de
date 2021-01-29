import * as react from "react";

export function footer(model, dispatch) {
    return react.createElement("div", {
        className: "w-full py-4 flex flex-col items-center justify-center",
    }, react.createElement("a", {
        className: "hover:text-blue-400",
        href: "https://www.notion.so/Impressum-1604d7b040c04f0c8083da6af93d6d54",
        target: "_blank",
    }, "Impressum"), react.createElement("div", {
        className: "flex",
    }, "Website by", react.createElement("a", {
        className: "pl-2 text-blue-500 hover:text-blue-400",
        href: "https://www.heimeshoff.de",
        target: "_blank",
    }, "Heimeshoff IT")));
}

