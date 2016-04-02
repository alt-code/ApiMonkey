<testsuite name="Mocha Tests" tests="426" failures="1" errors="1" skipped="0" timestamp="Sat, 02 Apr 2016 05:57:23 GMT" time="1.864">
<testcase classname="Route .all" name="should add handler" time="0.003"/>
<testcase classname="Route .all" name="should handle VERBS" time="0.004"/>
<testcase classname="Route .all" name="should stack" time="0"/>
<testcase classname="Route .VERB" name="should support .get" time="0"/>
<testcase classname="Route .VERB" name="should limit to just .VERB" time="0"/>
<testcase classname="Route .VERB" name="should allow fallthrough" time="0.001"/>
<testcase classname="Route errors" name="should handle errors via arity 4 functions" time="0.001"/>
<testcase classname="Route errors" name="should handle throw" time="0.001"/>
<testcase classname="Route errors" name="should handle throwing inside error handlers" time="0.001"/>
<testcase classname="Route errors" name="should handle throw in .all" time="0.001"/>
<testcase classname="Route errors" name="should handle single error handler" time="0"/>
<testcase classname="Router" name="should return a function with router methods" time="0.001"/>
<testcase classname="Router" name="should support .use of other routers" time="0.004"/>
<testcase classname="Router" name="should support dynamic routes" time="0.002"/>
<testcase classname="Router" name="should handle blank URL" time="0.001"/>
<testcase classname="Router" name="should not stack overflow with many registered routes" time="0.398"/>
<testcase classname="Router .handle" name="should dispatch" time="0.001"/>
<testcase classname="Router .multiple callbacks" name="should throw if a callback is null" time="0"/>
<testcase classname="Router .multiple callbacks" name="should throw if a callback is undefined" time="0.001"/>
<testcase classname="Router .multiple callbacks" name="should throw if a callback is not a function" time="0"/>
<testcase classname="Router .multiple callbacks" name="should not throw if all callbacks are functions" time="0"/>
<testcase classname="Router error" name="should skip non error middleware" time="0.001"/>
<testcase classname="Router error" name="should handle throwing inside routes with params" time="0.001"/>
<testcase classname="Router error" name="should handle throwing in handler after async param" time="0.001"/>
<testcase classname="Router error" name="should handle throwing inside error handlers" time="0"/>
<testcase classname="Router FQDN" name="should not obscure FQDNs" time="0.002"/>
<testcase classname="Router FQDN" name="should ignore FQDN in search" time="0.001"/>
<testcase classname="Router FQDN" name="should ignore FQDN in path" time="0"/>
<testcase classname="Router FQDN" name="should adjust FQDN req.url" time="0.001"/>
<testcase classname="Router FQDN" name="should adjust FQDN req.url with multiple handlers" time="0"/>
<testcase classname="Router FQDN" name="should adjust FQDN req.url with multiple routed handlers" time="0.001"/>
<testcase classname="Router .all" name="should support using .all to capture all http verbs" time="0.001"/>
<testcase classname="Router .use" name="should require arguments" time="0.001"/>
<testcase classname="Router .use" name="should not accept non-functions" time="0.002"/>
<testcase classname="Router .use" name="should accept array of middleware" time="0"/>
<testcase classname="Router .param" name="should call param function when routing VERBS" time="0"/>
<testcase classname="Router .param" name="should call param function when routing middleware" time="0"/>
<testcase classname="Router .param" name="should only call once per request" time="0"/>
<testcase classname="Router .param" name="should call when values differ" time="0.001"/>
<testcase classname="Router parallel requests" name="should not mix requests" time="0.052"/>
<testcase classname="app.all()" name="should add a router per method" time="0.072"/>
<testcase classname="app.all()" name="should run the callback for a method just once" time="0.009"/>
<testcase classname="app.del()" name="should alias app.delete()" time="0.004"/>
<testcase classname="app .engine(ext, fn)" name="should map a template engine" time="0.007"/>
<testcase classname="app .engine(ext, fn)" name="should throw when the callback is missing" time="0.001"/>
<testcase classname="app .engine(ext, fn)" name="should work without leading &quot;.&quot;" time="0.003"/>
<testcase classname="app .engine(ext, fn)" name="should work &quot;view engine&quot; setting" time="0.001"/>
<testcase classname="app .engine(ext, fn)" name="should work &quot;view engine&quot; with leading &quot;.&quot;" time="0.001"/>
<testcase classname="HEAD" name="should default to GET" time="0.008"/>
<testcase classname="HEAD" name="should output the same headers as GET requests" time="0.009"/>
<testcase classname="app.head()" name="should override" time="0.003"/>
<testcase classname="app" name="should inherit from event emitter" time="0.001"/>
<testcase classname="app" name="should be callable" time="0"/>
<testcase classname="app" name="should 404 without routes" time="0.005"/>
<testcase classname="app.parent" name="should return the parent when mounted" time="0.002"/>
<testcase classname="app.mountpath" name="should return the mounted path" time="0.002"/>
<testcase classname="app.router" name="should throw with notice" time="0"/>
<testcase classname="app.path()" name="should return the canonical" time="0.001"/>
<testcase classname="in development" name="should disable &quot;view cache&quot;" time="0.001"/>
<testcase classname="in production" name="should enable &quot;view cache&quot;" time="0"/>
<testcase classname="without NODE_ENV" name="should default to development" time="0.001"/>
<testcase classname="app.listen()" name="should wrap with an HTTP server" time="0"/>
<testcase classname="app .locals(obj)" name="should merge locals" time="0.001"/>
<testcase classname="app .locals.settings" name="should expose app settings" time="0.002"/>
<testcase classname="OPTIONS" name="should default to the routes defined" time="0.005"/>
<testcase classname="OPTIONS" name="should only include each method once" time="0.006"/>
<testcase classname="OPTIONS" name="should not be affected by app.all" time="0.005"/>
<testcase classname="OPTIONS" name="should not respond if the path is not defined" time="0.014"/>
<testcase classname="OPTIONS" name="should forward requests down the middleware chain" time="0.004"/>
<testcase classname="OPTIONS when error occurs in respone handler" name="should pass error to callback" time="0.004"/>
<testcase classname="app.options()" name="should override the default behavior" time="0.004"/>
<testcase classname="app .param(fn)" name="should map app.param(name, ...) logic" time="0.006"/>
<testcase classname="app .param(fn)" name="should fail if not given fn" time="0.001"/>
<testcase classname="app .param(names, fn)" name="should map the array" time="0.006"/>
<testcase classname="app .param(name, fn)" name="should map logic for a single param" time="0.004"/>
<testcase classname="app .param(name, fn)" name="should only call once per request" time="0.003"/>
<testcase classname="app .param(name, fn)" name="should call when values differ" time="0.005"/>
<testcase classname="app .param(name, fn)" name="should support altering req.params across routes" time="0.003"/>
<testcase classname="app .param(name, fn)" name="should not invoke without route handler" time="0.004"/>
<testcase classname="app .param(name, fn)" name="should work with encoded values" time="0.003"/>
<testcase classname="app .param(name, fn)" name="should catch thrown error" time="0.005"/>
<testcase classname="app .param(name, fn)" name="should catch thrown secondary error" time="0.004"/>
<testcase classname="app .param(name, fn)" name="should defer to next route" time="0.004"/>
<testcase classname="app .param(name, fn)" name="should defer all the param routes" time="0.004"/>
<testcase classname="app .param(name, fn)" name="should not call when values differ on error" time="0.006"/>
<testcase classname="app .param(name, fn)" name="should call when values differ when using &quot;next&quot;" time="0.003"/>
<testcase classname="app .render(name, fn)" name="should support absolute paths" time="0.002"/>
<testcase classname="app .render(name, fn)" name="should support absolute paths with &quot;view engine&quot;" time="0"/>
<testcase classname="app .render(name, fn)" name="should expose app.locals" time="0.001"/>
<testcase classname="app .render(name, fn)" name="should support index.&lt;engine&gt;" time="0.001"/>
<testcase classname="app .render(name, fn)" name="should handle render error throws" time="0"/>
<testcase classname="app .render(name, fn) when the file does not exist" name="should provide a helpful error" time="0"/>
<testcase classname="app .render(name, fn) when an error occurs" name="should invoke the callback" time="0.002"/>
<testcase classname="app .render(name, fn) when an extension is given" name="should render the template" time="0.001"/>
<testcase classname="app .render(name, fn) when &quot;view engine&quot; is given" name="should render the template" time="0"/>
<testcase classname="app .render(name, fn) when &quot;views&quot; is given" name="should lookup the file in the path" time="0"/>
<testcase classname="app .render(name, fn) when &quot;views&quot; is given when array of paths" name="should lookup the file in the path" time="0"/>
<testcase classname="app .render(name, fn) when &quot;views&quot; is given when array of paths" name="should lookup in later paths until found" time="0.001"/>
<testcase classname="app .render(name, fn) when &quot;views&quot; is given when array of paths" name="should error if file does not exist" time="0.002"/>
<testcase classname="app .render(name, fn) when a &quot;view&quot; constructor is given" name="should create an instance of it" time="0.001"/>
<testcase classname="app .render(name, fn) caching" name="should always lookup view without cache" time="0.001"/>
<testcase classname="app .render(name, fn) caching" name="should cache with &quot;view cache&quot; setting" time="0.002"/>
<testcase classname="app .render(name, options, fn)" name="should render the template" time="0.001"/>
<testcase classname="app .render(name, options, fn)" name="should expose app.locals" time="0.001"/>
<testcase classname="app .render(name, options, fn)" name="should give precedence to app.render() locals" time="0"/>
<testcase classname="app .render(name, options, fn) caching" name="should cache with cache option" time="0.001"/>
<testcase classname="app .request" name="should extend the request prototype" time="0.008"/>
<testcase classname="app .response" name="should extend the response prototype" time="0.006"/>
<testcase classname="app .response" name="should not be influenced by other app protos" time="0.003"/>
<testcase classname="app.route" name="should return a new route" time="0.004"/>
<testcase classname="app.route" name="should all .VERB after .all" time="0.003"/>
<testcase classname="app.route" name="should support dynamic routes" time="0.004"/>
<testcase classname="app.route" name="should not error on empty routes" time="0.003"/>
<testcase classname="app.router" name="should restore req.params after leaving router" time="0.004"/>
<testcase classname="app.router" name="should be .use()able" time="0.004"/>
<testcase classname="app.router" name="should allow escaped regexp" time="0.008"/>
<testcase classname="app.router" name="should allow literal &quot;.&quot;" time="0.004"/>
<testcase classname="app.router" name="should allow rewriting of the url" time="0.003"/>
<testcase classname="app.router" name="should run in order added" time="0.018"/>
<testcase classname="app.router" name="should be chainable" time="0"/>
<testcase classname="app.router methods" name="should include ACL" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.acl" time="0.001"/>
<testcase classname="app.router methods" name="should include BIND" time="0.002"/>
<testcase classname="app.router methods" name="should reject numbers for app.bind" time="0"/>
<testcase classname="app.router methods" name="should include CHECKOUT" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.checkout" time="0"/>
<testcase classname="app.router methods" name="should include COPY" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.copy" time="0.001"/>
<testcase classname="app.router methods" name="should include DELETE" time="0.004"/>
<testcase classname="app.router methods" name="should reject numbers for app.delete" time="0.001"/>
<testcase classname="app.router methods" name="should include GET" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.get" time="0.001"/>
<testcase classname="app.router methods" name="should include HEAD" time="0.004"/>
<testcase classname="app.router methods" name="should reject numbers for app.head" time="0.003"/>
<testcase classname="app.router methods" name="should include LINK" time="0.005"/>
<testcase classname="app.router methods" name="should reject numbers for app.link" time="0"/>
<testcase classname="app.router methods" name="should include LOCK" time="0.004"/>
<testcase classname="app.router methods" name="should reject numbers for app.lock" time="0"/>
<testcase classname="app.router methods" name="should include M-SEARCH" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.m-search" time="0"/>
<testcase classname="app.router methods" name="should include MERGE" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.merge" time="0.001"/>
<testcase classname="app.router methods" name="should include MKACTIVITY" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.mkactivity" time="0"/>
<testcase classname="app.router methods" name="should include MKCALENDAR" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.mkcalendar" time="0"/>
<testcase classname="app.router methods" name="should include MKCOL" time="0.004"/>
<testcase classname="app.router methods" name="should reject numbers for app.mkcol" time="0"/>
<testcase classname="app.router methods" name="should include MOVE" time="0.008"/>
<testcase classname="app.router methods" name="should reject numbers for app.move" time="0"/>
<testcase classname="app.router methods" name="should include NOTIFY" time="0.004"/>
<testcase classname="app.router methods" name="should reject numbers for app.notify" time="0"/>
<testcase classname="app.router methods" name="should include OPTIONS" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.options" time="0.001"/>
<testcase classname="app.router methods" name="should include PATCH" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.patch" time="0.001"/>
<testcase classname="app.router methods" name="should include POST" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.post" time="0.003"/>
<testcase classname="app.router methods" name="should include PROPFIND" time="0.015"/>
<testcase classname="app.router methods" name="should reject numbers for app.propfind" time="0"/>
<testcase classname="app.router methods" name="should include PROPPATCH" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.proppatch" time="0.001"/>
<testcase classname="app.router methods" name="should include PURGE" time="0.002"/>
<testcase classname="app.router methods" name="should reject numbers for app.purge" time="0.001"/>
<testcase classname="app.router methods" name="should include PUT" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.put" time="0.001"/>
<testcase classname="app.router methods" name="should include REBIND" time="0.005"/>
<testcase classname="app.router methods" name="should reject numbers for app.rebind" time="0.001"/>
<testcase classname="app.router methods" name="should include REPORT" time="0.006"/>
<testcase classname="app.router methods" name="should reject numbers for app.report" time="0.001"/>
<testcase classname="app.router methods" name="should include SEARCH" time="0.004"/>
<testcase classname="app.router methods" name="should reject numbers for app.search" time="0.002"/>
<testcase classname="app.router methods" name="should include SUBSCRIBE" time="0.004"/>
<testcase classname="app.router methods" name="should reject numbers for app.subscribe" time="0"/>
<testcase classname="app.router methods" name="should include TRACE" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.trace" time="0.001"/>
<testcase classname="app.router methods" name="should include UNBIND" time="0.002"/>
<testcase classname="app.router methods" name="should reject numbers for app.unbind" time="0"/>
<testcase classname="app.router methods" name="should include UNLINK" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.unlink" time="0"/>
<testcase classname="app.router methods" name="should include UNLOCK" time="0.002"/>
<testcase classname="app.router methods" name="should reject numbers for app.unlock" time="0.001"/>
<testcase classname="app.router methods" name="should include UNSUBSCRIBE" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.unsubscribe" time="0"/>
<testcase classname="app.router methods" name="should include DEL" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.del" time="0.001"/>
<testcase classname="app.router methods" name="should re-route when method is altered" time="0.009"/>
<testcase classname="app.router decode querystring" name="should decode correct params" time="0.004"/>
<testcase classname="app.router decode querystring" name="should not accept params in malformed paths" time="0.005"/>
<testcase classname="app.router decode querystring" name="should not decode spaces" time="0.004"/>
<testcase classname="app.router decode querystring" name="should work with unicode" time="0.007"/>
<testcase classname="app.router when given a regexp" name="should match the pathname only" time="0.003"/>
<testcase classname="app.router when given a regexp" name="should populate req.params with the captures" time="0.003"/>
<testcase classname="app.router case sensitivity" name="should be disabled by default" time="0.003"/>
<testcase classname="app.router case sensitivity when &quot;case sensitive routing&quot; is enabled" name="should match identical casing" time="0.004"/>
<testcase classname="app.router case sensitivity when &quot;case sensitive routing&quot; is enabled" name="should not match otherwise" time="0.003"/>
<testcase classname="app.router params" name="should overwrite existing req.params by default" time="0.005"/>
<testcase classname="app.router params" name="should allow merging existing req.params" time="0.007"/>
<testcase classname="app.router params" name="should use params from router" time="0.005"/>
<testcase classname="app.router params" name="should merge numeric indices req.params" time="0.005"/>
<testcase classname="app.router params" name="should merge numeric indices req.params when more in parent" time="0.005"/>
<testcase classname="app.router params" name="should merge numeric indices req.params when parent has same number" time="0.006"/>
<testcase classname="app.router params" name="should ignore invalid incoming req.params" time="0.004"/>
<testcase classname="app.router params" name="should restore req.params" time="0.004"/>
<testcase classname="app.router trailing slashes" name="should be optional by default" time="0.002"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should match trailing slashes" time="0.004"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should pass-though middleware" time="0.002"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should pass-though mounted middleware" time="0.004"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should match no slashes" time="0.003"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should match middleware when omitting the trailing slash" time="0.002"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should match middleware" time="0.004"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should match middleware when adding the trailing slash" time="0.002"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should fail when omitting the trailing slash" time="0.002"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should fail when adding the trailing slash" time="0.006"/>
<testcase classname="app.router *" name="should denote a greedy capture group" time="0.006"/>
<testcase classname="app.router *" name="should work with several" time="0.004"/>
<testcase classname="app.router *" name="should work cross-segment" time="0.006"/>
<testcase classname="app.router *" name="should allow naming" time="0.003"/>
<testcase classname="app.router *" name="should not be greedy immediately after param" time="0.004"/>
<testcase classname="app.router *" name="should eat everything after /" time="0.002"/>
<testcase classname="app.router *" name="should span multiple segments" time="0.003"/>
<testcase classname="app.router *" name="should be optional" time="0.003"/>
<testcase classname="app.router *" name="should require a preceding /" time="0.004"/>
<testcase classname="app.router *" name="should keep correct parameter indexes" time="0.005"/>
<testcase classname="app.router *" name="should work within arrays" time="0.005"/>
<testcase classname="app.router :name" name="should denote a capture group" time="0.004"/>
<testcase classname="app.router :name" name="should match a single segment only" time="0.003"/>
<testcase classname="app.router :name" name="should allow several capture groups" time="0.004"/>
<testcase classname="app.router :name" name="should work following a partial capture group" time="0.004"/>
<testcase classname="app.router :name" name="should work inside literal paranthesis" time="0.003"/>
<testcase classname="app.router :name" name="should work in array of paths" time="0.005"/>
<testcase classname="app.router :name?" name="should denote an optional capture group" time="0.003"/>
<testcase classname="app.router :name?" name="should populate the capture group" time="0.007"/>
<testcase classname="app.router .:name" name="should denote a format" time="0.015"/>
<testcase classname="app.router .:name?" name="should denote an optional format" time="0.012"/>
<testcase classname="app.router when next() is called" name="should continue lookup" time="0.003"/>
<testcase classname="app.router when next(&quot;route&quot;) is called" name="should jump to next route" time="0.003"/>
<testcase classname="app.router when next(err) is called" name="should break out of app.router" time="0.003"/>
<testcase classname="app.router when next(err) is called" name="should call handler in same route, if exists" time="0.004"/>
<testcase classname="app .VERB()" name="should not get invoked without error handler on error" time="0.004"/>
<testcase classname="app .VERB()" name="should only call an error handling routing callback when an error is propagated" time="0.005"/>
<testcase classname="app" name="should emit &quot;mount&quot; when mounted" time="0.001"/>
<testcase classname="app .use(app)" name="should mount the app" time="0.004"/>
<testcase classname="app .use(app)" name="should support mount-points" time="0.007"/>
<testcase classname="app .use(app)" name="should set the child's .parent" time="0.001"/>
<testcase classname="app .use(app)" name="should support dynamic routes" time="0.002"/>
<testcase classname="app .use(app)" name="should support mounted app anywhere" time="0.004"/>
<testcase classname="app .use(middleware)" name="should accept multiple arguments" time="0.003"/>
<testcase classname="app .use(middleware)" name="should invoke middleware for all requests" time="0.01"/>
<testcase classname="app .use(middleware)" name="should accept array of middleware" time="0.003"/>
<testcase classname="app .use(middleware)" name="should accept multiple arrays of middleware" time="0.002"/>
<testcase classname="app .use(middleware)" name="should accept nested arrays of middleware" time="0.003"/>
<testcase classname="app .use(path, middleware)" name="should reject missing functions" time="0"/>
<testcase classname="app .use(path, middleware)" name="should reject non-functions as middleware" time="0.001"/>
<testcase classname="app .use(path, middleware)" name="should strip path from req.url" time="0.003"/>
<testcase classname="app .use(path, middleware)" name="should accept multiple arguments" time="0.003"/>
<testcase classname="app .use(path, middleware)" name="should invoke middleware for all requests starting with path" time="0.007"/>
<testcase classname="app .use(path, middleware)" name="should work if path has trailing slash" time="0.007"/>
<testcase classname="app .use(path, middleware)" name="should accept array of middleware" time="0.003"/>
<testcase classname="app .use(path, middleware)" name="should accept multiple arrays of middleware" time="0.003"/>
<testcase classname="app .use(path, middleware)" name="should accept nested arrays of middleware" time="0.004"/>
<testcase classname="app .use(path, middleware)" name="should support array of paths" time="0.007"/>
<testcase classname="app .use(path, middleware)" name="should support array of paths with middleware array" time="0.006"/>
<testcase classname="app .use(path, middleware)" name="should support regexp path" time="0.009"/>
<testcase classname="app .use(path, middleware)" name="should support empty string path" time="0.002"/>
<testcase classname="config .set()" name="should set a value" time="0"/>
<testcase classname="config .set()" name="should return the app" time="0.001"/>
<testcase classname="config .set()" name="should return the app when undefined" time="0"/>
<testcase classname="config .set() &quot;etag&quot;" name="should throw on bad value" time="0.001"/>
<testcase classname="config .set() &quot;etag&quot;" name="should set &quot;etag fn&quot;" time="0"/>
<testcase classname="config .set() &quot;trust proxy&quot;" name="should set &quot;trust proxy fn&quot;" time="0.001"/>
<testcase classname="config .get()" name="should return undefined when unset" time="0"/>
<testcase classname="config .get()" name="should otherwise return the value" time="0.001"/>
<testcase classname="config .get() when mounted" name="should default to the parent app" time="0"/>
<testcase classname="config .get() when mounted" name="should given precedence to the child" time="0.001"/>
<testcase classname="config .get() when mounted" name="should inherit &quot;trust proxy&quot; setting" time="0"/>
<testcase classname="config .get() when mounted" name="should prefer child &quot;trust proxy&quot; setting" time="0.001"/>
<testcase classname="config .enable()" name="should set the value to true" time="0"/>
<testcase classname="config .disable()" name="should set the value to false" time="0.001"/>
<testcase classname="config .enabled()" name="should default to false" time="0"/>
<testcase classname="config .enabled()" name="should return true when set" time="0"/>
<testcase classname="config .disabled()" name="should default to true" time="0"/>
<testcase classname="config .disabled()" name="should return false when set" time="0"/>
<testcase classname="exports" name="should expose Router" time="0"/>
<testcase classname="exports" name="should expose the application prototype" time="0"/>
<testcase classname="exports" name="should expose the request prototype" time="0"/>
<testcase classname="exports" name="should expose the response prototype" time="0"/>
<testcase classname="exports" name="should permit modifying the .application prototype" time="0.001"/>
<testcase classname="exports" name="should permit modifying the .request prototype" time="0.003"/>
<testcase classname="exports" name="should permit modifying the .response prototype" time="0.003"/>
<testcase classname="exports" name="should throw on old middlewares" time="0.001"/>
<testcase classname="middleware .next()" name="should behave like connect" time="0.005"/>
<testcase classname="throw after .end()" name="should fail gracefully" time="0.003"/>
<testcase classname="req" name="should accept an argument list of type names" time="0.004"/>
<testcase classname="req .accepts(type)" name="should return true when Accept is not present" time="0.003"/>
<testcase classname="req .accepts(type)" name="should return true when present" time="0.003"/>
<testcase classname="req .accepts(type)" name="should return false otherwise" time="0.002"/>
<testcase classname="req .accepts(types)" name="should return the first when Accept is not present" time="0.003"/>
<testcase classname="req .accepts(types)" name="should return the first acceptable type" time="0.004"/>
<testcase classname="req .accepts(types)" name="should return false when no match is made" time="0.003"/>
<testcase classname="req .accepts(types)" name="should take quality into account" time="0.004"/>
<testcase classname="req .accepts(types)" name="should return the first acceptable type with canonical mime types" time="0.004"/>
<testcase classname="req .acceptsCharset(type) when Accept-Charset is not present" name="should return true" time="0.003"/>
<testcase classname="req .acceptsCharset(type) when Accept-Charset is not present" name="should return true when present" time="0.004"/>
<testcase classname="req .acceptsCharset(type) when Accept-Charset is not present" name="should return false otherwise" time="0.002"/>
<testcase classname="req .acceptsCharsets(type) when Accept-Charset is not present" name="should return true" time="0.003"/>
<testcase classname="req .acceptsCharsets(type) when Accept-Charset is not present" name="should return true when present" time="0.003"/>
<testcase classname="req .acceptsCharsets(type) when Accept-Charset is not present" name="should return false otherwise" time="0.002"/>
<testcase classname="req .acceptsEncoding" name="should be true if encoding accpeted" time="0.003"/>
<testcase classname="req .acceptsEncoding" name="should be false if encoding not accpeted" time="0.003"/>
<testcase classname="req .acceptsEncodingss" name="should be true if encoding accpeted" time="0.005"/>
<testcase classname="req .acceptsEncodingss" name="should be false if encoding not accpeted" time="0.004"/>
<testcase classname="req .acceptsLanguage" name="should be true if language accpeted" time="0.004"/>
<testcase classname="req .acceptsLanguage" name="should be false if language not accpeted" time="0.003"/>
<testcase classname="req .acceptsLanguage when Accept-Language is not present" name="should always return true" time="0.003"/>
<testcase classname="req .acceptsLanguages" name="should be true if language accpeted" time="0.003"/>
<testcase classname="req .acceptsLanguages" name="should be false if language not accpeted" time="0.003"/>
<testcase classname="req .acceptsLanguages when Accept-Language is not present" name="should always return true" time="0.003"/>
<testcase classname="req .baseUrl" name="should be empty for top-level route" time="0.003"/>
<testcase classname="req .baseUrl" name="should contain lower path" time="0.003"/>
<testcase classname="req .baseUrl" name="should contain full lower path" time="0.003"/>
<testcase classname="req .baseUrl" name="should travel through routers correctly" time="0.004"/>
<testcase classname="req .fresh" name="should return true when the resource is not modified" time="0.003"/>
<testcase classname="req .fresh" name="should return false when the resource is modified" time="0.003"/>
<testcase classname="req .fresh" name="should return false without response headers" time="0.003"/>
<testcase classname="req .get(field)" name="should return the header field value" time="0.003"/>
<testcase classname="req .get(field)" name="should special-case Referer" time="0.002"/>
<testcase classname="req .host" name="should return the Host when present" time="0.003"/>
<testcase classname="req .host" name="should strip port number" time="0.003"/>
<testcase classname="req .host" name="should return undefined otherwise" time="0.003"/>
<testcase classname="req .host" name="should work with IPv6 Host" time="0.002"/>
<testcase classname="req .host" name="should work with IPv6 Host and port" time="0.003"/>
<testcase classname="req .host when &quot;trust proxy&quot; is enabled" name="should respect X-Forwarded-Host" time="0.006"/>
<testcase classname="req .host when &quot;trust proxy&quot; is enabled" name="should ignore X-Forwarded-Host if socket addr not trusted" time="0.005"/>
<testcase classname="req .host when &quot;trust proxy&quot; is enabled" name="should default to Host" time="0.003"/>
<testcase classname="req .host when &quot;trust proxy&quot; is enabled when trusting hop count" name="should respect X-Forwarded-Host" time="0.003"/>
<testcase classname="req .host when &quot;trust proxy&quot; is disabled" name="should ignore X-Forwarded-Host" time="0.002"/>
<testcase classname="req .hostname" name="should return the Host when present" time="0.003"/>
<testcase classname="req .hostname" name="should strip port number" time="0.003"/>
<testcase classname="req .hostname" name="should return undefined otherwise" time="0.003"/>
<testcase classname="req .hostname" name="should work with IPv6 Host" time="0.002"/>
<testcase classname="req .hostname" name="should work with IPv6 Host and port" time="0.002"/>
<testcase classname="req .hostname when &quot;trust proxy&quot; is enabled" name="should respect X-Forwarded-Host" time="0.002"/>
<testcase classname="req .hostname when &quot;trust proxy&quot; is enabled" name="should ignore X-Forwarded-Host if socket addr not trusted" time="0.003"/>
<testcase classname="req .hostname when &quot;trust proxy&quot; is enabled" name="should default to Host" time="0.011"/>
<testcase classname="req .hostname when &quot;trust proxy&quot; is disabled" name="should ignore X-Forwarded-Host" time="0.002"/>
<testcase classname="req .ip when X-Forwarded-For is present when &quot;trust proxy&quot; is enabled" name="should return the client addr" time="0.005"/>
<testcase classname="req .ip when X-Forwarded-For is present when &quot;trust proxy&quot; is enabled" name="should return the addr after trusted proxy" time="0.003"/>
<testcase classname="req .ip when X-Forwarded-For is present when &quot;trust proxy&quot; is enabled" name="should return the addr after trusted proxy, from sub app" time="0.003"/>
<testcase classname="req .ip when X-Forwarded-For is present when &quot;trust proxy&quot; is disabled" name="should return the remote address" time="0.003"/>
<testcase classname="req .ip when X-Forwarded-For is not present" name="should return the remote address" time="0.002"/>
<testcase classname="req .ips when X-Forwarded-For is present when &quot;trust proxy&quot; is enabled" name="should return an array of the specified addresses" time="0.003"/>
<testcase classname="req .ips when X-Forwarded-For is present when &quot;trust proxy&quot; is enabled" name="should stop at first untrusted" time="0.002"/>
<testcase classname="req .ips when X-Forwarded-For is present when &quot;trust proxy&quot; is disabled" name="should return an empty array" time="0.004"/>
<testcase classname="req .ips when X-Forwarded-For is not present" name="should return []" time="0.002"/>
<testcase classname="req.is()" name="should ignore charset" time="0.001"/>
<testcase classname="req.is() when content-type is not present" name="should return false" time="0"/>
<testcase classname="req.is() when given an extension" name="should lookup the mime type" time="0"/>
<testcase classname="req.is() when given a mime type" name="should match" time="0"/>
<testcase classname="req.is() when given */subtype" name="should match" time="0.001"/>
<testcase classname="req.is() when given */subtype with a charset" name="should match" time="0"/>
<testcase classname="req.is() when given type/*" name="should match" time="0"/>
<testcase classname="req.is() when given type/* with a charset" name="should match" time="0"/>
<testcase classname="req .param(name, default)" name="should use the default value unless defined" time="0.003"/>
<testcase classname="req .param(name)" name="should check req.query" time="0.003"/>
<testcase classname="req .param(name)" name="should check req.body" time="0.022"/>
<testcase classname="req .param(name)" name="should check req.params" time="0.003"/>
<testcase classname="req .path" name="should return the parsed pathname" time="0.004"/>
<testcase classname="req .protocol" name="should return the protocol string" time="0.003"/>
<testcase classname="req .protocol when &quot;trust proxy&quot; is enabled" name="should respect X-Forwarded-Proto" time="0.004"/>
<testcase classname="req .protocol when &quot;trust proxy&quot; is enabled" name="should default to the socket addr if X-Forwarded-Proto not present" time="0.003"/>
<testcase classname="req .protocol when &quot;trust proxy&quot; is enabled" name="should ignore X-Forwarded-Proto if socket addr not trusted" time="0.003"/>
<testcase classname="req .protocol when &quot;trust proxy&quot; is enabled" name="should default to http" time="0.002"/>
<testcase classname="req .protocol when &quot;trust proxy&quot; is enabled when trusting hop count" name="should respect X-Forwarded-Proto" time="0.007"/>
<testcase classname="req .protocol when &quot;trust proxy&quot; is disabled" name="should ignore X-Forwarded-Proto" time="0.004"/>
<testcase classname="req .query" name="should default to {}" time="0.008"/>
<testcase classname="req .query" name="should default to parse complex keys" time="0.002"/>
<testcase classname="req .query when &quot;query parser&quot; is extended" name="should parse complex keys" time="0.003"/>
<testcase classname="req .query when &quot;query parser&quot; is extended" name="should parse parameters with dots" time="0.003"/>
<testcase classname="req .query when &quot;query parser&quot; is simple" name="should not parse complex keys" time="0.003"/>
<testcase classname="req .query when &quot;query parser&quot; is a function" name="should parse using function" time="0.003"/>
<testcase classname="req .query when &quot;query parser&quot; disabled" name="should not parse query" time="0.004"/>
<testcase classname="req .query when &quot;query parser&quot; disabled" name="should not parse complex keys" time="0.002"/>
<testcase classname="req .query when &quot;query parser fn&quot; is missing" name="should act like &quot;extended&quot;" time="0.003"/>
<testcase classname="req .query when &quot;query parser&quot; an unknown value" name="should throw" time="0.001"/>
<testcase classname="req .range(size)" name="should return parsed ranges" time="0.001"/>
<testcase classname="req .range(size)" name="should cap to the given size" time="0"/>
<testcase classname="req .range(size)" name="should have a .type" time="0"/>
<testcase classname="req .range(size)" name="should return undefined if no range" time="0"/>
<testcase classname="req .route" name="should be the executed Route" time="0.002"/>
<testcase classname="req .secure when X-Forwarded-Proto is missing" name="should return false when http" time="0.006"/>
<testcase classname="req .secure when X-Forwarded-Proto is present" name="should return false when http" time="0.005"/>
<testcase classname="req .secure when X-Forwarded-Proto is present" name="should return true when &quot;trust proxy&quot; is enabled" time="0.004"/>
<testcase classname="req .secure when X-Forwarded-Proto is present" name="should return false when initial proxy is http" time="0.003"/>
<testcase classname="req .secure when X-Forwarded-Proto is present" name="should return true when initial proxy is https" time="0.003"/>
<testcase classname="req .secure when X-Forwarded-Proto is present when &quot;trust proxy&quot; trusting hop count" name="should respect X-Forwarded-Proto" time="0.004"/>
<testcase classname="req .signedCookies" name="should return a signed JSON cookie" time="0.008"/>
<testcase classname="req .stale" name="should return false when the resource is not modified" time="0.004"/>
<testcase classname="req .stale" name="should return true when the resource is modified" time="0.003"/>
<testcase classname="req .stale" name="should return true without response headers" time="0.003"/>
<testcase classname="req .subdomains when present" name="should return an array" time="0.007"/>
<testcase classname="req .subdomains when present" name="should work with IPv4 address" time="0.003"/>
<testcase classname="req .subdomains when present" name="should work with IPv6 address" time="0.003"/>
<testcase classname="req .subdomains otherwise" name="should return an empty array" time="0.004"/>
<testcase classname="req .subdomains with no host" name="should return an empty array" time="0.003"/>
<testcase classname="req .subdomains with trusted X-Forwarded-Host" name="should return an array" time="0.004"/>
<testcase classname="req .subdomains when subdomain offset is set when subdomain offset is zero" name="should return an array with the whole domain" time="0.003"/>
<testcase classname="req .subdomains when subdomain offset is set when subdomain offset is zero" name="should return an array with the whole IPv4" time="0.003"/>
<testcase classname="req .subdomains when subdomain offset is set when subdomain offset is zero" name="should return an array with the whole IPv6" time="0.005"/>
<testcase classname="req .subdomains when subdomain offset is set when present" name="should return an array" time="0.008"/>
<testcase classname="req .subdomains when subdomain offset is set otherwise" name="should return an empty array" time="0.004"/>
<testcase classname="req .xhr" name="should return true when X-Requested-With is xmlhttprequest" time="0.004"/>
<testcase classname="req .xhr" name="should case-insensitive" time="0.002"/>
<testcase classname="req .xhr" name="should return false otherwise" time="0.004"/>
<testcase classname="req .xhr" name="should return false when not present" time="0.003"/>
<testcase classname="res .append(field, val)" name="should append multiple headers" time="0.004"/>
<testcase classname="res .append(field, val)" name="should accept array of values" time="0.003"/>
<testcase classname="res .append(field, val)" name="should get reset by res.set(field, val)" time="0.004"/>
<testcase classname="res .append(field, val)" name="should work with res.set(field, val) first" time="0.003"/>
<testcase classname="res .append(field, val)" name="should work with cookies" time="0.003"/>
<testcase classname="res .attachment()" name="should Content-Disposition to attachment" time="0.004"/>
<testcase classname="res .attachment(filename)" name="should add the filename param" time="0.004"/>
<testcase classname="res .attachment(filename)" name="should set the Content-Type" time="0.003"/>
<testcase classname="res .attachment(utf8filename)" name="should add the filename and filename* params" time="0.004"/>
<testcase classname="res .attachment(utf8filename)" name="should set the Content-Type" time="0.004"/>
<testcase classname="res .clearCookie(name)" name="should set a cookie passed expiry" time="0"><failure><![CDATA[Cannot read property 'should' of undefined
TypeError: Cannot read property 'should' of undefined
    at Test.&lt;anonymous&gt; (test/res.clearCookie.js:18:33)
    at Test.assert (node_modules/supertest/lib/test.js:156:6)
    at Server.assert (node_modules/supertest/lib/test.js:127:12)
    at emitCloseNT (net.js:1514:8)]]></failure></testcase>
</testsuite>
