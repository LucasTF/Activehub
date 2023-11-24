import {
  QueryClient,
  QueryClientProvider,
  useQuery,
} from "@tanstack/react-query";
import { ReactQueryDevtools } from "@tanstack/react-query-devtools";
import axios from "axios";

type ActivityType = {
  id: string;
  title: string;
  date: string;
  description: string;
  category: string;
  city: string;
  venue: string;
};

const queryClient = new QueryClient();

function App() {
  return (
    <QueryClientProvider client={queryClient}>
      <Activities />
      <ReactQueryDevtools initialIsOpen={false} />
    </QueryClientProvider>
  );
}

function Activities() {
  const query = useQuery({
    queryKey: ["activities"],
    queryFn: async () => {
      const response = await axios.get("http://localhost:5000/api/activities");
      return response.data as ActivityType[];
    },
  });

  return (
    <>
      <h1 className="text-3xl font-bold">Activehub</h1>
      <ul>
        {query.data?.map((activity) => {
          return <li key={activity.id}>{activity.title}</li>;
        })}
      </ul>
    </>
  );
}

export default App;
