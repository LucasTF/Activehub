import React from "react";

const Content = ({ children }: React.ComponentProps<"main">) => {
  return <main className="sm:mx-48">{children}</main>;
};

export default Content;
